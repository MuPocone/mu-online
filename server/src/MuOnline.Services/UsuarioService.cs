using Microsoft.Extensions.Options;
using MuOnline.Domain.Entities;
using MuOnline.Domain.Entities.Mu;
using MuOnline.Domain.Exceptions;
using MuOnline.Domain.Interfaces.Services;
using MuOnline.Domain.Templates;
using MuOnline.Infrastruture.Application.Core;
using MuOnline.Infrastruture.Application.Settings;
using System;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using MuOnline.Infrastructure.Identity.Core;
using MuOnline.Infrastructure.Identity.Model;

namespace MuOnline.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IRepository _repository;
        private readonly IEmailService _emailService;
        private readonly IAuthentication _authentication;
        private readonly string _urlBase;

        public UsuarioService(IOptions<AppSettings> appSettings, IRepository repository, IEmailService emailService, IAuthentication authentication)
        {
            _repository = repository;
            _emailService = emailService;
            _authentication = authentication;
            _urlBase = appSettings?.Value?.Route?.UrlBase;
        }

        public async Task RegistrarAsync(Guid aggregateId, string nomeUsuario, string senha, string email, string nome, DateTime? dataNascimento, string telefone)
        {
            Usuario.Validar(nomeUsuario, senha, email, nome, dataNascimento, telefone);

            var existeEmail = await _repository.ExistAsync<Usuario>(x => x.Email == email.ToLower());
            if (existeEmail) throw new UsuarioEmailJaCadastradoException();
            var existeNomeUsuario = await _repository.ExistAsync<Usuario>(x => x.NomeUsuario == nomeUsuario.ToLower());
            if (existeNomeUsuario) throw new UsuarioNomeUsuarioJaCadastradoException();

            var usuario = new Usuario(aggregateId, nomeUsuario, senha, email, nome, dataNascimento, telefone);
            await _repository.AddAsync(usuario);
        }

        public async Task EnviarConfirmacaoAsync(Guid aggregateId, string email, string nome)
        {
            var mensagem = string.Format(EmailTemplate.ConfirmacaoCadastro.Mensagem, LogoTemplate.LogoEmailCadastro, nome, _urlBase, aggregateId.ToString());
            await _emailService.SendAsync(new MailAddress(email), EmailTemplate.ConfirmacaoCadastro.Assunto, mensagem);
        }

        public async Task ConfirmarCadastroAsync(Guid aggregateId)
        {
            var usuario = await _repository.GetByAsync<Usuario>(aggregateId);
            if (usuario is null) throw new UsuarioNaoEncontradoException();

            usuario.ConfirmarEmail();
            var membInfo = new MembInfo(usuario.NomeUsuario, usuario.Senha, usuario.Nome, usuario.Email);
            if (membInfo is null) throw new ArgumentException("Algo deu errado =/ Entre em contato com o suporte!");

            await _repository.AddEntityMuAsync<MembInfo>(membInfo);
        }

        public async Task<dynamic> AutenticarAsync(string nomeUsuario, string senha)
        {
            var usuario = await _repository.GetByAsync<Usuario>(x => x.NomeUsuario == nomeUsuario);
            if (usuario is null) throw new UsuarioNaoEncontradoException();
            if (!usuario.EmailConfirmado) throw new UsuarioEmailNaoConfirmadoException();
            if (!usuario.Ativo) throw new UsuarioInativadoException();
            if (!string.Equals(usuario.Senha, senha, StringComparison.Ordinal))
                throw new UsuarioSenhaIncorretaException();

            var token = await _authentication.GenerateToken(usuario.AggregateId, usuario.Perfil.Descricao);
            var usuarioFront = new UserModel(usuario.AggregateId, usuario.Nome ?? usuario.NomeUsuario, usuario.Perfil.Descricao, usuario.PerfilId, token);
            return await Task.FromResult(usuarioFront);
        }

        public async Task RecuperarSenhaAsync(string nomeUsuario, string email)
        {
            var usuario = await _repository.GetByAsync<Usuario>(x => x.NomeUsuario == nomeUsuario.ToLower() || x.Email == email.ToLower());
            if (usuario is null) throw new UsuarioNaoEncontradoException();
            if (!usuario.EmailConfirmado) throw new UsuarioEmailNaoConfirmadoException();
            if (!usuario.Ativo) throw new UsuarioInativadoException();

            var mensagem = string.Format(EmailTemplate.RecuperarSenha.Mensagem, LogoTemplate.LogoEmailCadastro, usuario.Nome ?? usuario.NomeUsuario, usuario.Senha, _urlBase);
            await _emailService.SendAsync(new MailAddress(usuario.Email), EmailTemplate.RecuperarSenha.Assunto, mensagem);
        }

        public async Task<int> ObterOnlinesAsync()
        {
            var users = await _repository.GetEntityMuByAsync<MembStat>(x => x.ConnectStat == 1);
            return await Task.FromResult(users.Count());
        }

        public async Task<int> ObterContasAsync()
        {
            var total = await _repository.CountMuByAsync<MembInfo>(x => x.mail_chek == "1");
            return await Task.FromResult(total);
        }
    }
}

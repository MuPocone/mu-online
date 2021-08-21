using MuOnline.Domain.Enums;
using MuOnline.Domain.Exceptions;
using MuOnline.Infrastruture.Application.Core;
using System;
using System.Text.RegularExpressions;

namespace MuOnline.Domain.Entities
{
    public class Usuario : Entity
    {
        public string NomeUsuario { get; private set; }
        public string Senha { get; private set; }
        public string Email { get; private set; }
        public string Nome { get; private set; }
        public DateTime? DataNascimento { get; private set; }
        public string Telefone { get; private set; }
        public bool EmailConfirmado { get; private set; } 
        public bool Ativo { get; private set; }
        public int PerfilId { get; private set; }
        public virtual Perfil Perfil { get; protected set; }

        private static bool ValidaSenha(string senha) => !new Regex(RegexExpresionSenha).IsMatch(senha);
        private static bool ValidaEmail(string email) => !new Regex(RegexExpresionEmail).IsMatch(email);
         
        private const string RegexExpresionSenha = @"[a-zA-Z_0-9]";
        private const string RegexExpresionEmail = @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$";
        private const int TAMANHO_NOMEUSUARIO = 10;
        private const int TAMANHO_SENHA = 10;
        private const int TAMANHO_EMAIL = 80;
        private const int TAMANHO_NOME = 80;
        private const int TAMANHO_TELEFONE = 12;

        protected Usuario() { }

        public Usuario(Guid aggregateId, string nomeUsuario, string senha, string email, string nome, DateTime? dataNascimeto, string telefone)
        {
            AggregateId = aggregateId;
            DataCriacao = DateTime.Now;
            NomeUsuario = nomeUsuario;
            Senha = senha;
            Email = email;
            Nome = nome;
            DataNascimento = dataNascimeto;
            Telefone = telefone;
            PerfilId = (int) EPerfil.Usuario;
        }

        public Usuario(Guid aggregateId, string nomeUsuario, string senha, string email, string nome, DateTime? dataNascimeto, string telefone, int perfilId)
        {
            AggregateId = aggregateId;
            DataCriacao = DateTime.Now;
            NomeUsuario = nomeUsuario;
            Senha = senha;
            Email = email;
            Nome = nome;
            DataNascimento = dataNascimeto;
            Telefone = telefone;
            PerfilId = perfilId;
        }

        public void ConfirmarEmail()
        {
            EmailConfirmado = true;
            Ativo = true;
        }

        public static void Validar(string nomeUsuario, string senha, string email, string nome, DateTime? dataNascimento, string telefone)
        {
            if (string.IsNullOrWhiteSpace(nomeUsuario)) throw new ArgumentException(nameof(nomeUsuario));
            if (string.IsNullOrWhiteSpace(senha)) throw new ArgumentException(nameof(senha));
            if (string.IsNullOrWhiteSpace(email)) throw new ArgumentException(nameof(email));
            if (nomeUsuario.Length > TAMANHO_NOMEUSUARIO) throw new CampoMaiorQuePermitidoException(nameof(nomeUsuario), TAMANHO_NOMEUSUARIO);
            if (senha.Length > TAMANHO_SENHA) throw new CampoMaiorQuePermitidoException(nameof(senha), TAMANHO_SENHA);
            if (email.Length > TAMANHO_EMAIL) throw new CampoMaiorQuePermitidoException(nameof(email), TAMANHO_EMAIL);
            if (!string.IsNullOrWhiteSpace(nome) && nome.Length > TAMANHO_NOME) throw new CampoMaiorQuePermitidoException(nameof(nome), TAMANHO_NOME);
            if (!string.IsNullOrWhiteSpace(telefone) && telefone.Length > TAMANHO_TELEFONE) throw new CampoMaiorQuePermitidoException(nameof(telefone), TAMANHO_TELEFONE);
            if (dataNascimento.HasValue && (dataNascimento.Value.Date < new DateTime(1950, 01, 01) || dataNascimento.Value.Date > DateTime.Now.Date)) throw new ArgumentException("Data de nascimento invalida!");
            if (ValidaSenha(senha)) throw new ArgumentException("A senha deve ter apenas letras e números!");
            if (ValidaEmail(email)) throw new UsuarioEmailInvalidoException();
        }

        public static void ValidarPerfil(int perfilId)
        {
            if (!Enum.IsDefined(typeof(EPerfil), perfilId)) throw new UsuarioPerfilNaoEncontradoException();
        }
    }
}
using System;
using System.Threading.Tasks;

namespace MuOnline.Domain.Interfaces.Services
{
    public interface IUsuarioService
    {
        Task RegistrarAsync(Guid aggregateId, string nomeUsuario, string senha, string email, string nome, DateTime? dataNascimento, string telefone);
        Task EnviarConfirmacaoAsync(Guid aggregateId, string email, string nome);
        Task ConfirmarCadastroAsync(Guid aggregateId);
        Task<dynamic> AutenticarAsync(string nomeUsuario, string senha);
        Task RecuperarSenhaAsync(string nomeUsuario, string email);
        Task<int> ObterOnlinesAsync();
        Task<int> ObterContasAsync();
    }
}
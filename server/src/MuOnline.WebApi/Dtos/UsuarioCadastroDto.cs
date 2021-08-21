using System;

namespace MuOnline.WebApi.Dtos
{
    public class UsuarioCadastroDto
    {
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime? DataNascimento { get; set; }
    }
}
using System;

namespace MuOnline.Infrastructure.Identity.Model
{
    public class UserModel
    {
        public Guid? Id { get; set; }
        public string NomeUsuario { get; set; }
        public string Perfil { get; set; }
        public int PerfilId { get; set; }
        public string AccessToken { get; set; }

        public UserModel()
        {
            
        }

        public UserModel(Guid id, string nomeUsuario, string perfil, int perfilId, string accessToken)
        {
            Id = id;
            NomeUsuario = nomeUsuario;
            Perfil = perfil;
            PerfilId = perfilId;
            AccessToken = accessToken;
        }
    }
}
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using MuOnline.Infrastructure.Identity.Model;
using MuOnline.Infrastruture.Application.Settings;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MuOnline.Infrastructure.Identity.Core
{
    public class Authentication : IAuthentication
    {
        private readonly string _secret;
        private readonly int _expiration;

        public Authentication(IOptions<AppSettings> appSettings)
        {
            _secret = appSettings?.Value.TokenConfiguration.Secret ?? "Chave invalida";
            _expiration = appSettings?.Value.TokenConfiguration.Expiration ?? 0;
        }

        public async Task<string> GenerateToken(Guid aggregateId, string perfilId)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_secret);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Issuer = null,
                Audience = null,
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim("PerfilId", perfilId),
                    new Claim("Id", aggregateId.ToString())
                }),
                Expires = DateTime.UtcNow.AddMinutes(_expiration).ToUniversalTime(),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return await Task.FromResult(tokenHandler.WriteToken(token));
        }

        public async Task<UserModel> DecodeToken(string accessToken = null)
        {
            if (accessToken is null)
                return await Task.FromResult(new UserModel());

            var handler = new JwtSecurityTokenHandler();
            var authHeader = accessToken.Replace("Bearer ", "");
            var token = handler.ReadToken(authHeader) as JwtSecurityToken;

            var user = new UserModel();
            token?.Claims?.ToList().ForEach(item =>
            {
                user.Id = item?.Type == "Id" ? Guid.Parse(item.Value) : Guid.Empty;
                user.PerfilId = item?.Type == "PerfilId" ? Convert.ToInt32(item.Value) : 0;
            }); 

            if (!user.Id.HasValue)
                return await Task.FromResult(new UserModel());

            return await Task.FromResult(user);
        }
    }
}
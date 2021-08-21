using System;
using System.Threading.Tasks;
using MuOnline.Infrastructure.Identity.Model;

namespace MuOnline.Infrastructure.Identity.Core
{
    public interface IAuthentication
    {
        Task<string> GenerateToken(Guid aggregateId, string role);
        Task<UserModel> DecodeToken(string accessToken = null);
    }
}
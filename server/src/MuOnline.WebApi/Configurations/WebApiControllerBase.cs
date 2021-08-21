using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MuOnline.Infrastructure.Identity.Core;
using MuOnline.Infrastructure.Identity.Model;
using MuOnline.Infrastruture.Application.Core;
using MuOnline.WebApi.Filters;

namespace MuOnline.WebApi.Configurations
{
    [Authorize]
    [EnableCors("myAllowSpecificOriginsPolicy")]
    [ExceptionActionFilter]
    public class WebApiControllerBase : ControllerBase
    {
        protected IHttpContextAccessor ContextAccessor;
        protected IAuthentication Authentication;
        protected IUnitOfWork UnitOfWork;
        protected UserModel Usuario;

        public WebApiControllerBase(IHttpContextAccessor contextAccessor, IAuthentication authentication, IUnitOfWork unitOfWork)
        {
            ContextAccessor = contextAccessor;
            Authentication = authentication;
            UnitOfWork = unitOfWork;

            ObterUsuario();
        }

        private void ObterUsuario()
        {
            var accessToken = ContextAccessor.HttpContext.Request.Headers["Authorization"];
            
            if (!string.IsNullOrWhiteSpace(accessToken))
                Usuario = Authentication.DecodeToken(accessToken).GetAwaiter().GetResult();
        }
    }
}
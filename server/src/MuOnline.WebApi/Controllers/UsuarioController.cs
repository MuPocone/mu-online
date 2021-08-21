using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MuOnline.Domain.Interfaces.Services;
using MuOnline.Infrastructure.Identity.Core;
using MuOnline.Infrastruture.Application.Core;
using MuOnline.WebApi.Configurations;
using MuOnline.WebApi.Dtos;
using System;
using System.Net;
using System.Threading.Tasks;
using MuOnline.Infrastructure.Identity.Model;

namespace MuOnline.WebApi.Controllers
{
    [Route("usuario")]
    public class UsuarioController : WebApiControllerBase
    {
        public UsuarioController(IHttpContextAccessor contextAccessor, IAuthentication authentication, IUnitOfWork unitOfWork) : base(contextAccessor, authentication, unitOfWork) { }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> RegistrarAsync([FromServices] IUsuarioService service, [FromBody] UsuarioCadastroDto dto)
        {
            var aggregateId = Guid.NewGuid();

            await service.RegistrarAsync(aggregateId, dto.NomeUsuario, dto.Senha, dto.Email, dto.Nome, dto.DataNascimento, dto.Telefone);
            await UnitOfWork.CommitAsync();

            await service.EnviarConfirmacaoAsync(aggregateId, dto.Email, dto.Nome ?? dto.NomeUsuario);

            return Ok(aggregateId);
        }

        [HttpPost("confirmar")]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmarAsync([FromServices] IUsuarioService service, Guid hash)
        {
            await service.ConfirmarCadastroAsync(hash);
            await UnitOfWork.CommitAsync();

            return Ok();
        }

        [HttpPost("autenticar")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(UserModel), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> AutenticarAsync([FromServices] IUsuarioService service, [FromBody] UsuarioAutenticarDto dto)
        {
            return Ok(await service.AutenticarAsync(dto.NomeUsuario, dto.Senha));
        }

        [HttpPost("recuperar-senha")]
        [AllowAnonymous]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<IActionResult> RecuperarSenhaAsync([FromServices] IUsuarioService service, [FromBody] UsuarioRecuperarSenhaDto dto)
        {
            await service.RecuperarSenhaAsync(dto.NomeUsuario, dto.Email);
            return Ok();
        }

        [HttpGet("online")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> ObterOnlinesAsync([FromServices] IUsuarioService service)
        {
            return Ok(await service.ObterOnlinesAsync());
        }

        [HttpGet("contas")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> ObterContasAsync([FromServices] IUsuarioService service)
        {
            return Ok(await service.ObterContasAsync());
        }
    }
}

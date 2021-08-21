using MuOnline.Infrastruture.Application.Core;

namespace MuOnline.Domain.Exceptions
{
    public class CampoMaiorQuePermitidoException : BusinessException
    {
        public CampoMaiorQuePermitidoException(string campo, int tamanho) : base($"Campo: {campo} com tamanho maior que permitido! Tamanho máximo permitido é {tamanho}!") { }
    }
}
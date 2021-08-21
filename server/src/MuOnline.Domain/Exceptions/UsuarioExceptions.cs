using MuOnline.Infrastruture.Application.Core;

namespace MuOnline.Domain.Exceptions
{
    public class UsuarioEmailJaCadastradoException : BusinessException
    {
        public UsuarioEmailJaCadastradoException() : base("E-mail já cadastrado, tenta outro ai xomano!") { }
    }

    public class UsuarioNomeUsuarioJaCadastradoException : BusinessException
    {
        public UsuarioNomeUsuarioJaCadastradoException() : base("Nome do usuário já existe cadastrado! Escolha outro por favor.") { }
    }

    public class UsuarioPerfilNaoEncontradoException : BusinessException
    {
        public UsuarioPerfilNaoEncontradoException() : base("Perfil não encontrado!") { }
    }

    public class UsuarioNaoEncontradoException : BusinessException
    {
        public UsuarioNaoEncontradoException() : base("Usuário não encontrado!") { }
    }

    public class UsuarioEmailNaoConfirmadoException : BusinessException
    {
        public UsuarioEmailNaoConfirmadoException() : base("Confirme e-mail. Caso não apareca na caixa de entrada, verifique a spam.") { }
    }

    public class UsuarioInativadoException : BusinessException
    {
        public UsuarioInativadoException() : base("Usuário inativado!") { }
    }

    public class UsuarioSenhaIncorretaException : BusinessException
    {
        public UsuarioSenhaIncorretaException() : base("Senha incorreta!") { }
    }

    public class UsuarioEmailInvalidoException : BusinessException
    {
        public UsuarioEmailInvalidoException() : base("E-mail invalido!") { }
    }
}
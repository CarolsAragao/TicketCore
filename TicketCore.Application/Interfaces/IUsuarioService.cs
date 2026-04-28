using System;
using System.Collections.Generic;
using System.Text;
using TicketCore.Application.Dtos;

namespace TicketCore.Application.Interfaces
{
    public interface IUsuarioService
    {
        Task CriarUsuario(UsuarioDto usuario);
    }
}

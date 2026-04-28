using System;
using System.Collections.Generic;
using System.Text;
using TicketCore.Domain.Entities;

namespace TicketCore.Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        Task CriarUsuario(Usuario usuario);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using TicketCore.Domain.Entities;

namespace TicketCore.Application.Interfaces
{
    public interface IPasswordHasherService
    {
        string HashPassword(Usuario usuario, string senha);
        bool VerifyPassword(Usuario usuario, string senha, string senhaHash);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using TicketCore.Domain.enums;
using TicketCore.Domain.Shared;

namespace TicketCore.Domain.Entities
{
    public class Usuario : EntitiesBase
    {
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string SenhaHash { get; set; } = string.Empty;
        public PerfilUsuario Perfil { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TicketCore.Application.Dtos
{
    public class UsuarioDto
    {
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
    }
}

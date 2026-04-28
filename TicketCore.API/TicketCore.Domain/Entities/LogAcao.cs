using System;
using System.Collections.Generic;
using System.Text;
using TicketCore.Domain.Shared;

namespace TicketCore.Domain.Entities
{
    public class LogAcao : EntitiesBase
    {
        public string Acao { get; set; } = string.Empty;
        public string Data { get; set; } = string.Empty;
        public Guid ChamadoId { get; set; }
    }
}

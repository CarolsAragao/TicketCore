using System;
using System.Collections.Generic;
using System.Text;
using TicketCore.Domain.Shared;

namespace TicketCore.Domain.Entities
{
    public class Comentario : EntitiesBase
    {
        public string Mensagem { get; set; } = string.Empty;
        public Guid ChamadoId { get; set; }
    }
}

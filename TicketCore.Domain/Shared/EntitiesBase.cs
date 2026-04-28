using System;
using System.Collections.Generic;
using System.Text;

namespace TicketCore.Domain.Shared
{
    public class EntitiesBase
    {
        public Guid Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public Guid UsuarioId { get; set; }
    }
}

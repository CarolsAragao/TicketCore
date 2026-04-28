using System;
using System.Collections.Generic;
using System.Text;
using TicketCore.Domain.Enums;
using TicketCore.Domain.Shared;

namespace TicketCore.Domain.Entities
{
    public class Chamado : EntitiesBase
    {
        public string Titulo { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public StatusChamado Status { get; set; } = StatusChamado.ABERTO;
        public Prioridade Prioridade { get; set; } = Prioridade.BAIXA;
    }
}

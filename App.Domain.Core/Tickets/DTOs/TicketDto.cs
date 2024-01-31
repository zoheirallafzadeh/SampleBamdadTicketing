using App.Domain.Core.Tickets.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Tickets.DTOs
{
    public class TicketDto
    {
        public required int Id { get; set; }
        public required string Title { get; set; }
        public required List<int> MessegesId { get; set; }
        public int? UnitId { get; set; }
        public int? UnitPartId { get; set; }
        public required StateEnum State { get; set; }
        public required int CustomerUserId { get; set; }
    }
}

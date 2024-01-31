using App.Domain.Core.Tickets.Enum;
using App.Domain.Core.Units.Entities;
using App.Domain.Core.Users.Entitis;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace App.Domain.Core.Tickets.Entities
{
    public class Ticket
    {  
        public required int Id { get; set; }
        public required string Title { get; set; }
        public required List<Messege> Messeges { get; set; }
        public Unit? Unit { get; set; }
        public UnitPart? UnitPart { get; set; }
        public required StateEnum State { get; set; }
        public required User CustomerUser { get; set; }
    }
}

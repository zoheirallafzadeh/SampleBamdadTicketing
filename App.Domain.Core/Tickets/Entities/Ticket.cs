using App.Domain.Core.Tickets.Enum;
using App.Domain.Core.Units.Entities;
using App.Domain.Core.Users.Entitis;

namespace App.Domain.Core.Tickets.Entities
{
    public class Ticket
    {  
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Messege> Messeges { get; set; }
        public Unit Unit { get; set; }
        //public UnitPart UnitPart { get; set; }
        public StateEnum State { get; set; }
        public User CustomerUser { get; set; }

    }
}

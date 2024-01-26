using App.Domain.Core.Tickets.Enum;
using App.Domain.Core.Units.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Tickets.Entities
{
    public class Ticket
    {  
        public int Id { get; set; }
        public string Title { get; set; }
        public Unit Unit { get; set; }
        public UnitPart UnitPart { get; set; }
        public StateEnum State { get; set; }  

    }
}

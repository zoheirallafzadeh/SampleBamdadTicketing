using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Units.Entities
{
    public class UnitPart
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Unit Unit { get; set; }
    }
}

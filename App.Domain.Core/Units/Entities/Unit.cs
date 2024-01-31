using App.Domain.Core.Users.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Units.Entities
{
    public class Unit
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public List<UnitPart>? Parts { get; set; }
        public List<User>? MnagerUsers { get; set; }
    }
}

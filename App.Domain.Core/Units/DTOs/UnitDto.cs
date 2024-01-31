using App.Domain.Core.Units.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Units.DTOs
{
    public class UnitDto
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public List<int>? PartsId { get; set; }
        public List<int>? ManagerUsersId { get; set; }
    }
}

using App.Domain.Core.Units.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Units.Services
{
    public interface IUnitService
    {
        public Task Add(AddUnitDto Unit, CancellationToken cancellationToken);
        public Task Delete(int UnitId, CancellationToken cancellationToken);
        public Task Update(UnitDto Unit, CancellationToken cancellationToken);


        public Task<List<UnitDto>?> GetAllUnits(CancellationToken cancellationToken);
        public Task<UnitDto>? GetUnit(int UnitId, CancellationToken cancellationToken);
        public Task<List<UnitPartDto>?> GetUnitParts(int UnitId , CancellationToken cancellationToken);
    }
}

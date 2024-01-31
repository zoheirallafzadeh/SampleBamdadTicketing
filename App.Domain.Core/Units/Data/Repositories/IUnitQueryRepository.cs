using App.Domain.Core.Units.DTOs;

namespace App.Domain.Core.Units.Data.Repositories
{
    public interface IUnitQueryRepository
    {


        public Task<List<UnitDto>?> GetAllUnits(CancellationToken cancellationToken);
        public Task<List<UnitDto>?> GetUnit(int UnitId, CancellationToken cancellationToken);
        public Task<List<UnitPartDto>?> GetUnitParts(int UnitId, CancellationToken cancellationToken);


    }
}

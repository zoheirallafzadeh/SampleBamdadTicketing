using App.Domain.Core.Units.Data.Repositories;
using App.Domain.Core.Units.DTOs;

namespace App.Infra.Data.Repos.Ef.Units
{
    public class UnitQueryRepository : IUnitQueryRepository
    {
        public Task<List<UnitDto>?> GetAllUnits(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<UnitDto>?> GetUnit(int UnitId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<UnitPartDto>?> GetUnitParts(int UnitId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

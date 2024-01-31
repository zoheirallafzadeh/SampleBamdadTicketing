using App.Domain.Core.Units.Data.Repositories;
using App.Domain.Core.Units.DTOs;
using App.Infa.Data.Db.SqlServer.Ef.DbCtx;
using Microsoft.EntityFrameworkCore;

namespace App.Infra.Data.Repos.Ef.Units
{
    public class UnitQueryRepository : IUnitQueryRepository
    {
        private readonly AppDbContext _dbContext;
        public UnitQueryRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<UnitDto>?> GetAllUnits(CancellationToken cancellationToken)
        {
            return await _dbContext.Units.AsNoTracking().Select(p=>new UnitDto
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description
            }).ToListAsync(cancellationToken);
        }

        public async Task<UnitDto>? GetUnit(int UnitId, CancellationToken cancellationToken)
        {
            return await _dbContext.Units.AsNoTracking().Where(p => p.Id == UnitId).Select(p => new UnitDto
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description
            }).FirstOrDefaultAsync(cancellationToken);
        }

        public Task<List<UnitPartDto>?> GetUnitParts(int UnitId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

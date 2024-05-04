using App.Domain.Core.Units.Data.Repositories;
using App.Domain.Core.Units.DTOs;
using App.Domain.Core.Units.Entities;
using App.Infa.Data.Db.SqlServer.Ef.DbCtx;
using Microsoft.EntityFrameworkCore;

namespace App.Infra.Data.Repos.Ef.Units
{
    public class UnitCommandRepository : IUnitCommandRepository
    {
        private readonly AppDbContext _dbContext;
        public UnitCommandRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Add(AddUnitDto Unit, CancellationToken cancellationToken)
        {
            Unit newUnit = new()
            {
                Id = 0,
                Name = Unit.Name,
                Description = Unit.Description,
            };
            await _dbContext.Units.AddAsync(newUnit);
            await _dbContext.SaveChangesAsync();
            
        }

        public async Task Delete(int UnitId, CancellationToken cancellationToken)
        {
            var unit = await _dbContext.Units.FirstOrDefaultAsync(u => u.Id == UnitId, cancellationToken: cancellationToken);
            if (unit != null)
            {
                _dbContext.Units.Remove(unit);
                await _dbContext.SaveChangesAsync(cancellationToken);
            }
        }

        public async Task Update(UnitDto Unit, CancellationToken cancellationToken)
        {
            var oldUnit = await _dbContext.Units.FirstOrDefaultAsync(u => u.Id == Unit.Id, cancellationToken);
            if (oldUnit != null)
            {
                oldUnit.Name = Unit.Name;
                oldUnit.Description = Unit.Description;
                await _dbContext.SaveChangesAsync(cancellationToken);
            }
        }
    }
}

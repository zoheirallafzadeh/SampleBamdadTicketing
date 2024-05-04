using App.Domain.Core.Units.DTOs;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Units.Data.Repositories
{
    public interface IUnitCommandRepository
    {
        public Task Add(AddUnitDto Unit , CancellationToken cancellationToken);
        public Task Delete(int UnitId , CancellationToken cancellationToken);
        public Task Update(UnitDto Unit , CancellationToken cancellationToken);
    }
}

using App.Domain.Core.Units.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Units.Data.Repositories
{
    public interface IUnitCommandRepository
    {
        public Task Add(UnitDto Unit , CancellationToken cancellationToken);

    }
}

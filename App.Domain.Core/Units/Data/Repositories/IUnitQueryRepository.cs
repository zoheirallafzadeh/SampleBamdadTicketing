﻿using App.Domain.Core.Units.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Units.Data.Repositories
{
    public interface IUnitQueryRepository
    {
        public Task<List<UnitDto>?> GetUnits(CancellationToken cancellationToken);
        public Task<List<UnitDto>> GetUnit(int UnitId , CancellationToken cancellationToken);
        public Task<List<UnitPartDto>> GetUnitParts(CancellationToken cancellationToken);
    }
}
using App.Domain.Core.Units.AppServices;
using App.Domain.Core.Units.DTOs;
using App.Domain.Core.Units.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices.Units
{
    public class UnitAppService : IUnitAppService
    {
        private readonly IUnitService _unitService;
        public async Task Add(UnitDto Unit, CancellationToken cancellationToken)
        {
            await _unitService.Add(Unit, cancellationToken);
        }

        public async Task Delete(int UnitId, CancellationToken cancellationToken)
        {
            await _unitService.Delete(UnitId, cancellationToken);
        }

        public async Task<List<UnitDto>?> GetAllUnits(CancellationToken cancellationToken)
        {
            return await _unitService.GetAllUnits(cancellationToken);
        }

        public async Task<List<UnitDto>?> GetUnit(int UnitId, CancellationToken cancellationToken)
        {
            return await _unitService.GetUnit(UnitId, cancellationToken);
        }

        public async Task<List<UnitPartDto>?> GetUnitParts(int UnitId, CancellationToken cancellationToken)
        {
            return await _unitService.GetUnitParts(UnitId, cancellationToken);
        }

        public async Task Update(UnitDto Unit, CancellationToken cancellationToken)
        {
            await _unitService.Update(Unit, cancellationToken);
        }
    }
}

using App.Domain.Core.Units.Data.Repositories;
using App.Domain.Core.Units.DTOs;
using App.Domain.Core.Units.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.Units
{
    public class UnitService : IUnitService
    {
        private readonly IUnitQueryRepository _unitQueryRepository;
        private readonly IUnitCommandRepository _unitCommandRepository;
        public async Task Add(UnitDto Unit, CancellationToken cancellationToken)
        {
            await _unitCommandRepository.Add(Unit, cancellationToken);
        }

        public async Task Delete(int UnitId, CancellationToken cancellationToken)
        {
            await _unitCommandRepository.Delete(UnitId, cancellationToken);
        }

        public async Task<List<UnitDto>?> GetAllUnits(CancellationToken cancellationToken)
        {
            return await _unitQueryRepository.GetAllUnits(cancellationToken);
        }

        public async Task<List<UnitDto>?> GetUnit(int UnitId, CancellationToken cancellationToken)
        {
            return await _unitQueryRepository.GetUnit(UnitId, cancellationToken);
        }

        public async Task<List<UnitPartDto>?> GetUnitParts(int UnitId, CancellationToken cancellationToken)
        {
            return await _unitQueryRepository.GetUnitParts(UnitId, cancellationToken);
        }

        public async Task Update(UnitDto Unit, CancellationToken cancellationToken)
        {
            await _unitCommandRepository.Update(Unit, cancellationToken);
        }




    }
}

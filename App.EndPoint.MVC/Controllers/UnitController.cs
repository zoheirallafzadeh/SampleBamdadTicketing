using Microsoft.AspNetCore.Mvc;
using App.Domain.Core.Units.AppServices;
using App.EndPoint.MVC.Models;

namespace App.EndPoint.MVC.Controllers
{
    public class UnitController : Controller
    {
        private readonly IUnitAppService _unitAppService;
        public UnitController(IUnitAppService unitAppService)
        {
            _unitAppService = unitAppService;
        }
        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            var Units = await _unitAppService.GetAllUnits(cancellationToken);
            IEnumerable<UnitViewModel> unitViewModels = Units.Select(p => new UnitViewModel()
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,

            }
            );
            return View(unitViewModels);
        }
    }
}

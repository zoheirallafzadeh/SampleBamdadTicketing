using App.Domain.Core.Units.AppServices;
using App.Domain.Core.Units.DTOs;
using App.EndPoint.MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoint.MVC.Areas.Admin.Controllers
{

    [Area("Admin")]
    //[Authorize(Roles = "Admin")]
    public class UnitController : Controller
    {
        private readonly IUnitAppService _unitAppService;
        public UnitController(IUnitAppService unitAppService)
        {
            _unitAppService = unitAppService;
        }


        [HttpPost]
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

        [HttpPost]
        public IActionResult Add()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Add(AddUnitDto addUnitDto , CancellationToken cancellationToken)
        {
            return RedirectToAction();
        }
        
    }
}

using App.Domain.Core.Tickets.Entities;
using App.Domain.Core.Units.AppServices;
using App.Domain.Core.Units.DTOs;
using App.EndPoint.MVC.Areas.Admin.Models;
using App.EndPoint.MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UnitViewModel = App.EndPoint.MVC.Models.UnitViewModel;

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
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddUnitDto addUnitDto, CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
            {
                if (addUnitDto.Name != null)
                {
                    await _unitAppService.Add(addUnitDto, cancellationToken);
                }
            }


            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                var unit = await _unitAppService.GetUnit(id, cancellationToken);
                Models.UnitViewModel unitViewModel = new Models.UnitViewModel
                {
                    Id = unit.Id,
                    Name = unit.Name,
                };

                return View(unitViewModel);
            }

        }


        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            if (id != null)
            {
                await _unitAppService.Delete(id, cancellationToken);
            }
            return RedirectToAction("Index");
        }



    }
}

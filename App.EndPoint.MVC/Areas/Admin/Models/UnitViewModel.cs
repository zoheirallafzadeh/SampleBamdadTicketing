using System.ComponentModel.DataAnnotations;

namespace App.EndPoint.MVC.Areas.Admin.Models
{
    public class UnitViewModel
    {
        [Display(Name = "آیدی")]
        public required int Id { get; set; }
        [Display(Name = "نام")]
        public required string Name { get; set; }
        [Display(Name = "توضیحات")]
        public string? Description { get; set; }
    }
}

namespace App.Domain.Core.Units.DTOs
{
    public class AddUnitDto
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
    }
}

namespace App.Domain.Core.Units.DTOs
{
    internal class AddUnitDto
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace MaqsMeadowCreations.Data.Models;

public class JewelryItem
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [MaxLength(50)]
    public string Category { get; set; } = string.Empty;

    [MaxLength(500)]
    public string? Description { get; set; }

    [Range(0, 10000)]
    public decimal Price { get; set; }

    public bool IsAvailable { get; set; }

    [MaxLength(500)]
    public string? ImageUrl { get; set; }

    public int LeadTimeDays { get; set; } = 7;
}

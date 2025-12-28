using System.ComponentModel.DataAnnotations;

namespace MaqsMeadowCreations.Data.Models;

public class CustomRequestModel
{
    [Required]
    [MaxLength(80)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Phone]
    [Display(Name = "Phone (optional)")]
    public string? Phone { get; set; }

    [Required]
    [Display(Name = "Preferred piece")]
    public string PreferredItemType { get; set; } = string.Empty;

    [Required]
    [Display(Name = "Flower details")]
    [MaxLength(800)]
    public string FlowerDetails { get; set; } = string.Empty;

    [Display(Name = "Metal preference")]
    public string? MetalPreference { get; set; }

    [Range(25, 10000, ErrorMessage = "Budget should be at least $25")]
    public decimal? Budget { get; set; }

    [Display(Name = "Ideal timeline")]
    public string? Timeline { get; set; }

    [Display(Name = "Payment preference")]
    public string? PaymentPreference { get; set; }

    [Display(Name = "Additional details")]
    [MaxLength(1000)]
    public string? AdditionalNotes { get; set; }
}

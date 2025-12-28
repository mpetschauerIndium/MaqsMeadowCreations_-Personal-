using MaqsMeadowCreations.Data;
using MaqsMeadowCreations.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace MaqsMeadowCreations.Services;

public class JewelryCatalogService(ApplicationDbContext context)
{
    private static readonly List<JewelryItem> SampleItems =
    [
        new()
        {
            Name = "Pressed Violet Necklace",
            Category = "Necklaces",
            Description = "Real violets sealed in resin with a gold-fill chain.",
            Price = 115,
            IsAvailable = true,
            ImageUrl = "images/necklace.jpg",
            LeadTimeDays = 10
        },
        new()
        {
            Name = "Wildflower Hoop Earrings",
            Category = "Earrings",
            Description = "Floating blooms framed in a lightweight hoop for everyday wear.",
            Price = 78,
            IsAvailable = true,
            ImageUrl = "images/earrings.jpg",
            LeadTimeDays = 7
        },
        new()
        {
            Name = "Fern & Daisy Keepsake Coaster",
            Category = "Coasters",
            Description = "Botanical coaster that doubles as art on your coffee table.",
            Price = 48,
            IsAvailable = true,
            ImageUrl = "images/coaster.jpg",
            LeadTimeDays = 5
        },
        new()
        {
            Name = "Mini Meadow Wall Hanging",
            Category = "Wall Pieces",
            Description = "Pressed garden finds set in a minimalist frame.",
            Price = 165,
            IsAvailable = false,
            ImageUrl = "images/wallpiece.jpg",
            LeadTimeDays = 21
        }
    ];

    public async Task<List<JewelryItem>> GetAvailableItemsAsync()
    {
        // Prefer SQL Server via EF Core when configured and reachable, otherwise fall back to curated samples.
        try
        {
            if (await context.Database.CanConnectAsync())
            {
                return await context.JewelryItems
                    .OrderBy(i => i.Category)
                    .ThenBy(i => i.Name)
                    .ToListAsync();
            }
        }
        catch
        {
            // Swallow connection issues and return curated data for now.
        }

        return SampleItems;
    }
}

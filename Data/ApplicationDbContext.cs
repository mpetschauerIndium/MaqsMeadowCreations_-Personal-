using MaqsMeadowCreations.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace MaqsMeadowCreations.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<JewelryItem> JewelryItems => Set<JewelryItem>();
}

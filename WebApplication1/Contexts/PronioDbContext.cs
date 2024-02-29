using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Contexts;

public class PronioDbContext: DbContext
{
    public PronioDbContext(DbContextOptions<PronioDbContext>options):base(options)
    {
        
    }
    public DbSet<Slider> Sliders { get; set; } = null!;
    public DbSet<Shipping> Shippings { get; set; } = null!;
}

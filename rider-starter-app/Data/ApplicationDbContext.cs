using Microsoft.EntityFrameworkCore;
using rider_starter_app.Models;

namespace rider_starter_app.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    
    public DbSet<Category> Categories { get; set; }
}
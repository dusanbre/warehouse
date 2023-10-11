using Microsoft.EntityFrameworkCore;

namespace Warehouse.Data;

public class ApiDbContext: DbContext
{
    public ApiDbContext(DbContextOptions<ApiDbContext> options): base(options)
    {
        
    }
    
    public DbSet<Models.Warehouse> Warehouses { get; set; }
}
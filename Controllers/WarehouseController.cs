using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Warehouse.Data;

namespace Warehouse.Controllers;

[ApiController]
[Route("[controller]")]
public class WarehouseController: ControllerBase
{
    private readonly ApiDbContext _apiDbContext;
    
    public WarehouseController(ApiDbContext context)
    {
        _apiDbContext = context;
    }

    [HttpGet(Name = "GetAllWarehouses")]
    public async Task<IActionResult> Get()
    {
        var warehouse = new Models.Warehouse()
        {
            Name = "Test name",
            Desctiption = "Test desc",
            Address = "Test addr"
        };

        _apiDbContext.Add(warehouse);

        await _apiDbContext.SaveChangesAsync();

        var response = await _apiDbContext.Warehouses.ToListAsync();

        return Ok(response);
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; 
using shop.Data;
using shop.Models; 


[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
	private readonly ShopContext _context;

	public ProductsController(ShopContext context)
	{
		_context = context;
	}


	[HttpGet]
	public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
	{
		var products = await _context.Products.ToListAsync();
		return Ok(products); 
	}


}

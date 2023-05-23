using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.Data;
using SharedResources.Models;

namespace Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        AppDbContext _appDbContext;
        public ProductController(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }


        [HttpGet]
        public async Task<IEnumerable<Product>> Get() => await _appDbContext.Products.ToListAsync();

        [HttpGet("{id}", Name = "GetProduct")]
        public async Task<Product?> Get(string id) => await _appDbContext.Products.FindAsync(id);

        [HttpPost]
        public async Task<IActionResult> Post(Product product)
        {
            product.Id = Guid.NewGuid().ToString();
            await _appDbContext.Products.AddAsync(product);
            await _appDbContext.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = product.Id }, product);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, Product product)
        {
            if (id != product.Id)
                return BadRequest();
            _appDbContext.Entry(product).State = EntityState.Modified;
            await _appDbContext.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var product = await _appDbContext.Products.FindAsync(id);
            if (product == null)
                return NotFound();
            _appDbContext.Products.Remove(product);
            await _appDbContext.SaveChangesAsync();
            return NoContent();
        }
    }
}
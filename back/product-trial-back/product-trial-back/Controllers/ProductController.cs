using Microsoft.AspNetCore.Mvc;
using Project.DTO;
using Project.Infrastructure;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace product_trial_back.Controllers
{
    [Route("products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Products>>> GetProducts()
        {
            var products = await _productService.GetAllProductsAsync();
            return Ok(products);
        }

        [HttpPost]
        public async Task<ActionResult<Products>> PostProduct(Products product)
        {
            await _productService.AddProductAsync(product);
            return CreatedAtAction(nameof(GetProduct), new { id = product.id }, product);
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Products>> GetProduct(int id)
        {
            var product = await _productService.GetProductByIdAsync(1);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> PutProduct(int id, Products product)
        {
            if(id != 1 || product.id != 1)
                return BadRequest();
            else
            {
                var productSearch = await _productService.GetProductByIdAsync(1);
                if (productSearch == null)
                    return BadRequest();
                else
                {
                    await _productService.UpdateProductAsync(product);
                    return NoContent();
                }

            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _productService.DeleteProductAsync(1);
            return NoContent();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OterpBackend.Models;

namespace Oterp_Back_end.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductMovementController : ControllerBase
    {
        private readonly OterpContext _context;

        public ProductMovementController(OterpContext context)
        {
            _context = context;
        }

        // GET: api/ProductMovement
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductMovement>>> GetProductMovementList()
        {
            return await _context.ProductMovementList.ToListAsync();
        }

        // GET: api/ProductMovement/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductMovement>> GetProductMovement(int id)
        {
            var productMovement = await _context.ProductMovementList.FindAsync(id);

            if (productMovement == null)
            {
                return NotFound();
            }

            return productMovement;
        }

        // PUT: api/ProductMovement/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductMovement(int id, ProductMovement productMovement)
        {
            if (id != productMovement.IDProductMovement)
            {
                return BadRequest();
            }

            _context.Entry(productMovement).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductMovementExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ProductMovement
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductMovement>> PostProductMovement(ProductMovement productMovement)
        {
            _context.ProductMovementList.Add(productMovement);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductMovement", new { id = productMovement.IDProductMovement }, productMovement);
        }

        // DELETE: api/ProductMovement/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductMovement(int id)
        {
            var productMovement = await _context.ProductMovementList.FindAsync(id);
            if (productMovement == null)
            {
                return NotFound();
            }

            _context.ProductMovementList.Remove(productMovement);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductMovementExists(int id)
        {
            return _context.ProductMovementList.Any(e => e.IDProductMovement == id);
        }
    }
}

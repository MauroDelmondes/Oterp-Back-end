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
    public class SaleOrderItemController : ControllerBase
    {
        private readonly OterpContext _context;

        public SaleOrderItemController(OterpContext context)
        {
            _context = context;
        }

        // GET: api/SaleOrderItem
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SaleOrderItem>>> GetSaleOrderItemList()
        {
            return await _context.SaleOrderItemList.ToListAsync();
        }

        // GET: api/SaleOrderItem/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SaleOrderItem>> GetSaleOrderItem(int id)
        {
            var saleOrderItem = await _context.SaleOrderItemList.FindAsync(id);

            if (saleOrderItem == null)
            {
                return NotFound();
            }

            return saleOrderItem;
        }

        // PUT: api/SaleOrderItem/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSaleOrderItem(int id, SaleOrderItem saleOrderItem)
        {
            if (id != saleOrderItem.IDSaleOrderItem)
            {
                return BadRequest();
            }

            _context.Entry(saleOrderItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SaleOrderItemExists(id))
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

        // POST: api/SaleOrderItem
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SaleOrderItem>> PostSaleOrderItem(SaleOrderItem saleOrderItem)
        {
            _context.SaleOrderItemList.Add(saleOrderItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSaleOrderItem", new { id = saleOrderItem.IDSaleOrderItem }, saleOrderItem);
        }

        // DELETE: api/SaleOrderItem/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSaleOrderItem(int id)
        {
            var saleOrderItem = await _context.SaleOrderItemList.FindAsync(id);
            if (saleOrderItem == null)
            {
                return NotFound();
            }

            _context.SaleOrderItemList.Remove(saleOrderItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SaleOrderItemExists(int id)
        {
            return _context.SaleOrderItemList.Any(e => e.IDSaleOrderItem == id);
        }
    }
}

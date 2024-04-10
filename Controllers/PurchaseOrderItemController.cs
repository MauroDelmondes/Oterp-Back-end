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
    public class PurchaseOrderItemController : ControllerBase
    {
        private readonly OterpContext _context;

        public PurchaseOrderItemController(OterpContext context)
        {
            _context = context;
        }

        // GET: api/PurchaseOrderItem
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PurchaseOrderItem>>> GetPurchaseOrderItemList()
        {
            return await _context.PurchaseOrderItemList.ToListAsync();
        }

        // GET: api/PurchaseOrderItem/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PurchaseOrderItem>> GetPurchaseOrderItem(int id)
        {
            var purchaseOrderItem = await _context.PurchaseOrderItemList.FindAsync(id);

            if (purchaseOrderItem == null)
            {
                return NotFound();
            }

            return purchaseOrderItem;
        }

        // PUT: api/PurchaseOrderItem/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPurchaseOrderItem(int id, PurchaseOrderItem purchaseOrderItem)
        {
            if (id != purchaseOrderItem.IDPurchaseOrderItem)
            {
                return BadRequest();
            }

            _context.Entry(purchaseOrderItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PurchaseOrderItemExists(id))
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

        // POST: api/PurchaseOrderItem
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PurchaseOrderItem>> PostPurchaseOrderItem(PurchaseOrderItem purchaseOrderItem)
        {
            _context.PurchaseOrderItemList.Add(purchaseOrderItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPurchaseOrderItem", new { id = purchaseOrderItem.IDPurchaseOrderItem }, purchaseOrderItem);
        }

        // DELETE: api/PurchaseOrderItem/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePurchaseOrderItem(int id)
        {
            var purchaseOrderItem = await _context.PurchaseOrderItemList.FindAsync(id);
            if (purchaseOrderItem == null)
            {
                return NotFound();
            }

            _context.PurchaseOrderItemList.Remove(purchaseOrderItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PurchaseOrderItemExists(int id)
        {
            return _context.PurchaseOrderItemList.Any(e => e.IDPurchaseOrderItem == id);
        }
    }
}

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
    public class PurchaseOrderInstallmentController : ControllerBase
    {
        private readonly OterpContext _context;

        public PurchaseOrderInstallmentController(OterpContext context)
        {
            _context = context;
        }

        // GET: api/PurchaseOrderInstallment
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PurchaseOrderInstallment>>> GetPurchaseOrderInstallmentList()
        {
            return await _context.PurchaseOrderInstallmentList.ToListAsync();
        }

        // GET: api/PurchaseOrderInstallment/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PurchaseOrderInstallment>> GetPurchaseOrderInstallment(int id)
        {
            var purchaseOrderInstallment = await _context.PurchaseOrderInstallmentList.FindAsync(id);

            if (purchaseOrderInstallment == null)
            {
                return NotFound();
            }

            return purchaseOrderInstallment;
        }

        // PUT: api/PurchaseOrderInstallment/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPurchaseOrderInstallment(int id, PurchaseOrderInstallment purchaseOrderInstallment)
        {
            if (id != purchaseOrderInstallment.IDPurchaseOrderInstallment)
            {
                return BadRequest();
            }

            _context.Entry(purchaseOrderInstallment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PurchaseOrderInstallmentExists(id))
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

        // POST: api/PurchaseOrderInstallment
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PurchaseOrderInstallment>> PostPurchaseOrderInstallment(PurchaseOrderInstallment purchaseOrderInstallment)
        {
            _context.PurchaseOrderInstallmentList.Add(purchaseOrderInstallment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPurchaseOrderInstallment", new { id = purchaseOrderInstallment.IDPurchaseOrderInstallment }, purchaseOrderInstallment);
        }

        // DELETE: api/PurchaseOrderInstallment/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePurchaseOrderInstallment(int id)
        {
            var purchaseOrderInstallment = await _context.PurchaseOrderInstallmentList.FindAsync(id);
            if (purchaseOrderInstallment == null)
            {
                return NotFound();
            }

            _context.PurchaseOrderInstallmentList.Remove(purchaseOrderInstallment);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PurchaseOrderInstallmentExists(int id)
        {
            return _context.PurchaseOrderInstallmentList.Any(e => e.IDPurchaseOrderInstallment == id);
        }
    }
}

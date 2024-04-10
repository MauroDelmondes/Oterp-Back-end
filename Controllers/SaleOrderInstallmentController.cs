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
    public class SaleOrderInstallmentController : ControllerBase
    {
        private readonly OterpContext _context;

        public SaleOrderInstallmentController(OterpContext context)
        {
            _context = context;
        }

        // GET: api/SaleOrderInstallment
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SaleOrderInstallment>>> GetSaleOrderInstallmentList()
        {
            return await _context.SaleOrderInstallmentList.ToListAsync();
        }

        // GET: api/SaleOrderInstallment/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SaleOrderInstallment>> GetSaleOrderInstallment(int id)
        {
            var saleOrderInstallment = await _context.SaleOrderInstallmentList.FindAsync(id);

            if (saleOrderInstallment == null)
            {
                return NotFound();
            }

            return saleOrderInstallment;
        }

        // PUT: api/SaleOrderInstallment/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSaleOrderInstallment(int id, SaleOrderInstallment saleOrderInstallment)
        {
            if (id != saleOrderInstallment.IDSaleOrderInstallment)
            {
                return BadRequest();
            }

            _context.Entry(saleOrderInstallment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SaleOrderInstallmentExists(id))
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

        // POST: api/SaleOrderInstallment
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SaleOrderInstallment>> PostSaleOrderInstallment(SaleOrderInstallment saleOrderInstallment)
        {
            _context.SaleOrderInstallmentList.Add(saleOrderInstallment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSaleOrderInstallment", new { id = saleOrderInstallment.IDSaleOrderInstallment }, saleOrderInstallment);
        }

        // DELETE: api/SaleOrderInstallment/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSaleOrderInstallment(int id)
        {
            var saleOrderInstallment = await _context.SaleOrderInstallmentList.FindAsync(id);
            if (saleOrderInstallment == null)
            {
                return NotFound();
            }

            _context.SaleOrderInstallmentList.Remove(saleOrderInstallment);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SaleOrderInstallmentExists(int id)
        {
            return _context.SaleOrderInstallmentList.Any(e => e.IDSaleOrderInstallment == id);
        }
    }
}

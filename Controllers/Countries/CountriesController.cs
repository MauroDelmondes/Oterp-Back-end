using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OterpBackend.Models;

namespace Oterp_Back_end.Controllers_Countries
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly CountriesContext _context;

        public CountriesController(CountriesContext context)
        {
            _context = context;
        }

        // GET: api/Countries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Countries>>> GetCountriesList()
        {
            return await _context.CountriesList.ToListAsync();
        }

        // GET: api/Countries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Countries>> GetCountries(int id)
        {
            var countries = await _context.CountriesList.FindAsync(id);

            if (countries == null)
            {
                return NotFound();
            }

            return countries;
        }

        // PUT: api/Countries/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCountries(int id, Countries countries)
        {
            if (id != countries.Id)
            {
                return BadRequest();
            }

            _context.Entry(countries).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CountriesExists(id))
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

        // POST: api/Countries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Countries>> PostCountries(Countries countries)
        {
            _context.CountriesList.Add(countries);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetCountries", new { id = countries.Id }, countries);
            return CreatedAtAction(nameof(GetCountries), new { id = countries.Id }, countries);
        }

        // DELETE: api/Countries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCountries(int id)
        {
            var countries = await _context.CountriesList.FindAsync(id);
            if (countries == null)
            {
                return NotFound();
            }

            _context.CountriesList.Remove(countries);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CountriesExists(int id)
        {
            return _context.CountriesList.Any(e => e.Id == id);
        }
    }
}

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
  public class CitiesController : ControllerBase
  {
    private readonly OterpContext _context;

    public CitiesController(OterpContext context)
    {
      _context = context;
    }

    // GET: api/Cities
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Cities>>> GetCitiesList()
    {
      return await _context.CitiesList.ToListAsync();
    }

    // GET: api/Cities/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Cities>> GetCities(int id)
    {
      var cities = await _context.CitiesList.FindAsync(id);

      if (cities == null)
      {
        return NotFound();
      }

      return cities;
    }

    // PUT: api/Cities/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutCities(int id, Cities cities)
    {
      if (id != cities.IDCity)
      {
        return BadRequest();
      }

      _context.Entry(cities).State = EntityState.Modified;

      try
      {
        await _context.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!CitiesExists(id))
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

    // POST: api/Cities
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Cities>> PostCities(Cities cities)
    {
      _context.CitiesList.Add(cities);
      await _context.SaveChangesAsync();

      return CreatedAtAction(nameof(GetCities), new { id = cities.IDCity }, cities);
    }

    // DELETE: api/Cities/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCities(int id)
    {
      var cities = await _context.CitiesList.FindAsync(id);
      if (cities == null)
      {
        return NotFound();
      }

      _context.CitiesList.Remove(cities);
      await _context.SaveChangesAsync();

      return NoContent();
    }

    private bool CitiesExists(int id)
    {
      return _context.CitiesList.Any(e => e.IDCity == id);
    }
  }
}

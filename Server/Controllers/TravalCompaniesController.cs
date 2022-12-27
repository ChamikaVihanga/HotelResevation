using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hotel.Server.Data;
using Hotel.Shared.Entites;

namespace Hotel.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravalCompaniesController : ControllerBase
    {
        private readonly AddDbContext _context;

        public TravalCompaniesController(AddDbContext context)
        {
            _context = context;
        }

        // GET: api/TravalCompanies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TravalCompany>>> GetTravalCompanies()
        {
            return await _context.TravalCompanies.ToListAsync();
        }

        // GET: api/TravalCompanies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TravalCompany>> GetTravalCompany(int id)
        {
            var travalCompany = await _context.TravalCompanies.FindAsync(id);

            if (travalCompany == null)
            {
                return NotFound();
            }

            return travalCompany;
        }

        // PUT: api/TravalCompanies/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTravalCompany(int id, TravalCompany travalCompany)
        {
            if (id != travalCompany.Id)
            {
                return BadRequest();
            }

            _context.Entry(travalCompany).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TravalCompanyExists(id))
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

        // POST: api/TravalCompanies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TravalCompany>> PostTravalCompany(TravalCompany travalCompany)
        {
            _context.TravalCompanies.Add(travalCompany);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTravalCompany", new { id = travalCompany.Id }, travalCompany);
        }

        // DELETE: api/TravalCompanies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTravalCompany(int id)
        {
            var travalCompany = await _context.TravalCompanies.FindAsync(id);
            if (travalCompany == null)
            {
                return NotFound();
            }

            _context.TravalCompanies.Remove(travalCompany);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TravalCompanyExists(int id)
        {
            return _context.TravalCompanies.Any(e => e.Id == id);
        }
    }
}

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
    public class ResevationsController : ControllerBase
    {
        private readonly AddDbContext _context;

        public ResevationsController(AddDbContext context)
        {
            _context = context;
        }

        // GET: api/Resevations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Resevation>>> GetResevations()
        {
            return await _context.Resevations.ToListAsync();
        }

        // GET: api/Resevations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Resevation>> GetResevation(int id)
        {
            var resevation = await _context.Resevations.FindAsync(id);

            if (resevation == null)
            {
                return NotFound();
            }

            return resevation;
        }

        // PUT: api/Resevations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutResevation(int id, Resevation resevation)
        {
            if (id != resevation.Id)
            {
                return BadRequest();
            }

            _context.Entry(resevation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ResevationExists(id))
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

        // POST: api/Resevations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Resevation>> PostResevation(Resevation resevation)
        {
            _context.Resevations.Add(resevation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetResevation", new { id = resevation.Id }, resevation);
        }

        // DELETE: api/Resevations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteResevation(int id)
        {
            var resevation = await _context.Resevations.FindAsync(id);
            if (resevation == null)
            {
                return NotFound();
            }

            _context.Resevations.Remove(resevation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ResevationExists(int id)
        {
            return _context.Resevations.Any(e => e.Id == id);
        }
    }
}

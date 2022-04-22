using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using iniciativa.Data;
using iniciativa.Models;

namespace iniciativa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IniciativaWomanController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public IniciativaWomanController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/IniciativaWoman
        [HttpGet]
        public async Task<ActionResult<IEnumerable<IniciativaWoman>>> GetIniciativas()
        {
            return await _context.Iniciativas.Include("Eventos"). ToListAsync();
        }

        // GET: api/IniciativaWoman/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IniciativaWoman>> GetIniciativaWoman(int id)
        {
            var iniciativaWoman = await _context.Iniciativas.Include("Eventos").FirstOrDefaultAsync(x => x.id == id);

            if (iniciativaWoman == null)
            {
                return NotFound();
            }

            return iniciativaWoman;
        }

        // PUT: api/IniciativaWoman/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIniciativaWoman(int id, IniciativaWoman iniciativaWoman)
        {
            if (id != iniciativaWoman.id)
            {
                return BadRequest();
            }

            _context.Entry(iniciativaWoman).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IniciativaWomanExists(id))
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

        // POST: api/IniciativaWoman
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<IniciativaWoman>> PostIniciativaWoman(IniciativaWoman iniciativaWoman)
        {
            _context.Iniciativas.Add(iniciativaWoman);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIniciativaWoman", new { id = iniciativaWoman.id }, iniciativaWoman);
        }

        // DELETE: api/IniciativaWoman/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIniciativaWoman(int id)
        {
            var iniciativaWoman = await _context.Iniciativas.FindAsync(id);
            if (iniciativaWoman == null)
            {
                return NotFound();
            }

            _context.Iniciativas.Remove(iniciativaWoman);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool IniciativaWomanExists(int id)
        {
            return _context.Iniciativas.Any(e => e.id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using api_Humanos.Context;
using api_Humanos.Models;

namespace api_Humanos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HumanosController : ControllerBase
    {
        private readonly context _context;

        public HumanosController(context context)
        {
            _context = context;
        }

        // GET: api/Humanos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Humanos>>> GetHumanos()
        {
            return await _context.Humanos.ToListAsync();
        }

        // GET: api/Humanos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Humanos>> GetHumanos(int id)
        {
            var humanos = await _context.Humanos.FindAsync(id);

            if (humanos == null)
            {
                return NotFound();
            }

            return humanos;
        }

        // PUT: api/Humanos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHumanos(int id, Humanos humanos)
        {
            if (id != humanos.Id)
            {
                return BadRequest();
            }

            _context.Entry(humanos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HumanosExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok();
        }

        // POST: api/Humanos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Humanos>> PostHumanos(Humanos humanos)
        {
            _context.Humanos.Add(humanos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHumanos", new { id = humanos.Id }, humanos);
        }

        private bool HumanosExists(int id)
        {
            return _context.Humanos.Any(e => e.Id == id);
        }
    }
}

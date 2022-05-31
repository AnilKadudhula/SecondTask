using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SecondTask.Data;

namespace SecondTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EsplEmployeesController : ControllerBase
    {
        private readonly SecondDbContext _context;

        public EsplEmployeesController(SecondDbContext context)
        {
            _context = context;
        }

        // GET: api/EsplEmployees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EsplEmployee>>> GetEmployees()
        {
          if (_context.Employees == null)
          {
              return NotFound();
          }
            return await _context.Employees.ToListAsync();
        }

        // GET: api/EsplEmployees/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EsplEmployee>> GetEsplEmployee(int id)
        {
          if (_context.Employees == null)
          {
              return NotFound();
          }
            var esplEmployee = await _context.Employees.FindAsync(id);

            if (esplEmployee == null)
            {
                return NotFound();
            }

            return esplEmployee;
        }

        // PUT: api/EsplEmployees/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEsplEmployee(int id, EsplEmployee esplEmployee)
        {
            if (id != esplEmployee.ID)
            {
                return BadRequest();
            }

            _context.Entry(esplEmployee).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EsplEmployeeExists(id))
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

        // POST: api/EsplEmployees
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EsplEmployee>> PostEsplEmployee(EsplEmployee esplEmployee)
        {
          if (_context.Employees == null)
          {
              return Problem("Entity set 'SecondDbContext.Employees'  is null.");
          }
            _context.Employees.Add(esplEmployee);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEsplEmployee", new { id = esplEmployee.ID }, esplEmployee);
        }

        // DELETE: api/EsplEmployees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEsplEmployee(int id)
        {
            if (_context.Employees == null)
            {
                return NotFound();
            }
            var esplEmployee = await _context.Employees.FindAsync(id);
            if (esplEmployee == null)
            {
                return NotFound();
            }

            _context.Employees.Remove(esplEmployee);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EsplEmployeeExists(int id)
        {
            return (_context.Employees?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}

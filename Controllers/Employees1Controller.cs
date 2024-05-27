using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PAYROL_SYSTEM.Context;
using PAYROL_SYSTEM.Models;

namespace PAYROL_SYSTEM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Employees1Controller : ControllerBase
    {
        private readonly AppDbContext _context;

        public Employees1Controller(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Employees1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employees>>> GetEmployees()
        {
            return await _context.Employees.ToListAsync();
        }

        // GET: api/Employees1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Employees>> GetEmployees(string id)
        {
            var employees = await _context.Employees.FindAsync(id);

            if (employees == null)
            {
                return NotFound();
            }
            return employees;
        }

        // PUT: api/Employees1/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployees(string id, Employees employees)
        {
            if (id != employees.strId)
            {
                return BadRequest();
            }
            _context.Entry(employees).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeesExists(id))
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

        // POST: api/Employees1
        [HttpPost]
        public async Task<ActionResult<Employees>> PostEmployees(Employees employees)
        {
            _context.Employees.Add(employees);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmployees", new { id = employees.strId }, employees);
        }

        // DELETE: api/Employees1/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Employees>> DeleteEmployees(string id)
        {
            var employees = await _context.Employees.FindAsync(id);
            if (employees == null)
            {
                return NotFound();
            }

            _context.Employees.Remove(employees);
            await _context.SaveChangesAsync();

            return employees;
        }

        private bool EmployeesExists(string id)
        {
            return _context.Employees.Any(e => e.strId == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PAYROL_SYSTEM.Context;
using PAYROL_SYSTEM.Models;

namespace PAYROL_SYSTEM.Controllers
{
    public class TestTestTestController : Controller
    {
        private readonly AppDbContext _context;

        public TestTestTestController(AppDbContext context)
        {
            _context = context;
        }

        // GET: TestTestTest
        public async Task<IActionResult> Index()
        {
            return View(await _context.Employees.ToListAsync());
        }

        // GET: TestTestTest/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employees = await _context.Employees
                .FirstOrDefaultAsync(m => m.strId == id);
            if (employees == null)
            {
                return NotFound();
            }

            return View(employees);
        }

        // GET: TestTestTest/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TestTestTest/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("strId,strFullName,strIdNo,strNHIF_No,strNSSF_NO,strEmail,strIdKRAPIN,strDetartmentId,strRole,strPhoneNo,strDate_Of_Join,strActive_Status,strJobGroupId,strGender,strReligion,strDateOfBirth,strMarital_Status,strBank_Name,strAccountNo,strStaff_No,strSacco_Deductyion,strLoan,strPenalties")] Employees employees)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employees);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employees);
        }

        // GET: TestTestTest/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employees = await _context.Employees.FindAsync(id);
            if (employees == null)
            {
                return NotFound();
            }
            return View(employees);
        }

        // POST: TestTestTest/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("strId,strFullName,strIdNo,strNHIF_No,strNSSF_NO,strEmail,strIdKRAPIN,strDetartmentId,strRole,strPhoneNo,strDate_Of_Join,strActive_Status,strJobGroupId,strGender,strReligion,strDateOfBirth,strMarital_Status,strBank_Name,strAccountNo,strStaff_No,strSacco_Deductyion,strLoan,strPenalties")] Employees employees)
        {
            if (id != employees.strId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employees);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeesExists(employees.strId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(employees);
        }

        // GET: TestTestTest/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employees = await _context.Employees
                .FirstOrDefaultAsync(m => m.strId == id);
            if (employees == null)
            {
                return NotFound();
            }

            return View(employees);
        }

        // POST: TestTestTest/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var employees = await _context.Employees.FindAsync(id);
            _context.Employees.Remove(employees);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeesExists(string id)
        {
            return _context.Employees.Any(e => e.strId == id);
        }
    }
}

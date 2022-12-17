using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using complete_crud_mvc_6.Models;

namespace complete_crud_mvc_6.Controllers
{
    public class TranController : Controller
    {
        private readonly TransDbContext _context;

        public TranController(TransDbContext context)
        {
            _context = context;
        }

        // GET: Tran
        public async Task<IActionResult> Index()
        {
              return View(await _context.Trans.ToListAsync());
        }

        // GET: Tran/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Trans == null)
            {
                return NotFound();
            }

            var trans = await _context.Trans
                .FirstOrDefaultAsync(m => m.TransID == id);
            if (trans == null)
            {
                return NotFound();
            }

            return View(trans);
        }

        // GET: Tran/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tran/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TransID,AccountNumber,BeneficiaryName,BankName,SWIFTCode,Amount,Date")] Trans trans)
        {
            if (ModelState.IsValid)
            {
                _context.Add(trans);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(trans);
        }

        // GET: Tran/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Trans == null)
            {
                return NotFound();
            }

            var trans = await _context.Trans.FindAsync(id);
            if (trans == null)
            {
                return NotFound();
            }
            return View(trans);
        }

        // POST: Tran/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TransID,AccountNumber,BeneficiaryName,BankName,SWIFTCode,Amount,Date")] Trans trans)
        {
            if (id != trans.TransID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(trans);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransExists(trans.TransID))
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
            return View(trans);
        }

        // GET: Tran/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Trans == null)
            {
                return NotFound();
            }

            var trans = await _context.Trans
                .FirstOrDefaultAsync(m => m.TransID == id);
            if (trans == null)
            {
                return NotFound();
            }

            return View(trans);
        }

        // POST: Tran/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Trans == null)
            {
                return Problem("Entity set 'TransDbContext.Trans'  is null.");
            }
            var trans = await _context.Trans.FindAsync(id);
            if (trans != null)
            {
                _context.Trans.Remove(trans);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransExists(int id)
        {
          return _context.Trans.Any(e => e.TransID == id);
        }
    }
}

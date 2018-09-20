using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ContadordeCalorias.web.Models;

namespace ContadordeCalorias.web.Controllers
{
    public class NutricionalInfocsController : Controller
    {
        private readonly DataContext _context;

        public NutricionalInfocsController(DataContext context)
        {
            _context = context;
        }

        // GET: NutricionalInfocs
        public async Task<IActionResult> Index()
        {
            return View(await _context.NutricionalInfocs.ToListAsync());
        }

        // GET: NutricionalInfocs/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nutricionalInfocs = await _context.NutricionalInfocs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nutricionalInfocs == null)
            {
                return NotFound();
            }

            return View(nutricionalInfocs);
        }

        // GET: NutricionalInfocs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NutricionalInfocs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Descripcion,Calorias")] NutricionalInfocs nutricionalInfocs)
        {
            if (ModelState.IsValid)
            {
                nutricionalInfocs.Id = Guid.NewGuid();
                _context.Add(nutricionalInfocs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nutricionalInfocs);
        }

        // GET: NutricionalInfocs/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nutricionalInfocs = await _context.NutricionalInfocs.FindAsync(id);
            if (nutricionalInfocs == null)
            {
                return NotFound();
            }
            return View(nutricionalInfocs);
        }

        // POST: NutricionalInfocs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Descripcion,Calorias")] NutricionalInfocs nutricionalInfocs)
        {
            if (id != nutricionalInfocs.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nutricionalInfocs);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NutricionalInfocsExists(nutricionalInfocs.Id))
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
            return View(nutricionalInfocs);
        }

        // GET: NutricionalInfocs/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nutricionalInfocs = await _context.NutricionalInfocs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nutricionalInfocs == null)
            {
                return NotFound();
            }

            return View(nutricionalInfocs);
        }

        // POST: NutricionalInfocs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var nutricionalInfocs = await _context.NutricionalInfocs.FindAsync(id);
            _context.NutricionalInfocs.Remove(nutricionalInfocs);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NutricionalInfocsExists(Guid id)
        {
            return _context.NutricionalInfocs.Any(e => e.Id == id);
        }
    }
}

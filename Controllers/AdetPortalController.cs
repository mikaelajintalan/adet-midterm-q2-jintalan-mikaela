using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using trylangsamidtermquiz2.Models;

namespace trylangsamidtermquiz2.Controllers
{
    public class AdetPortalController : Controller
    {
        private readonly AdetPortalDbContext _DB;

        public AdetPortalController(AdetPortalDbContext DB)
        {
            _DB = DB;
        }

        // GET: StudentPortal/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adetportal = await _DB.StudentPortal
                .FirstOrDefaultAsync(m => m.Id == id);

            if (adetportal == null)
            {
                return NotFound();
            }

            return View(adetportal);
        }

        // GET: StudentPortal/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StudentPortal/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StudentNumber,StudentName,Quiz1,Quiz2,Quiz3,Ass1,Ass2,Ass3")] AdetPortal adetportal)
        {
            if (ModelState.IsValid)
            {
                _DB.Add(adetportal);
                await _DB.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(adetportal);
        }

        // GET: StudentPortal/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adetportal = await _DB.StudentPortal.FindAsync(id);
            if (adetportal == null)
            {
                return NotFound();
            }
            return View(adetportal);
        }

        // POST: StudentPortal/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,StudentNumber,StudentName,Quiz1,Quiz2,Quiz3,Ass1,Ass2,Ass3")] AdetPortal adetportal)
        {
            if (id != adetportal.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _DB.Update(adetportal);
                    await _DB.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdetPortalExists(adetportal.Id))
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
            return View(adetportal);
        }

        // GET: StudentPortal/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adetportal = await _DB.StudentPortal
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adetportal == null)
            {
                return NotFound();
            }

            return View(adetportal);
        }

        // POST: StudentPortal/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var adetportal = await _DB.StudentPortal.FindAsync(id);
            _DB.StudentPortal.Remove(adetportal);
            await _DB.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdetPortalExists(int id)
        {
            return _DB.StudentPortal.Any(e => e.Id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using adet_midterm_q2_jintalan_mikaela.Models;

namespace adet_midterm_q2_jintalan_mikaela.Controllers
{
    public class AdetPortalController : Controller
    {
        private readonly AdetPortalDbContext _DB;

        public AdetPortalController(AdetPortalDbContext DB)
        {
            _DB = DB;
        }

        // GET: StudentPortal
        public async Task<IActionResult> Index()
        {
            return View(await _DB.StudentPortal.ToListAsync());
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
        public async Task<IActionResult> Create([Bind("Id,StudentNumber,StudentName,PQ1,PQ2,PQ3,PA1,PA2,PA3,PCG,MQ1,MQ2,MQ3,MA1,MA2,MA3,MCG,PFQ1,PFQ2,PFQ3,PFA1,PFA2,PFA3,PFCG,FQ1,FQ2,FQ3,FA1,FA2,FA3,FCG")] AdetPortal adetportal)
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
        public async Task<IActionResult> Edit(int id, [Bind("Id,StudentNumber,StudentName,PQ1,PQ2,PQ3,PA1,PA2,PA3,PCG,MQ1,MQ2,MQ3,MA1,MA2,MA3,MCG,PFQ1,PFQ2,PFQ3,PFA1,PFA2,PFA3,PFCG,FQ1,FQ2,FQ3,FA1,FA2,FA3,FCG")] AdetPortal adetportal)
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

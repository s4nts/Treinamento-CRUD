using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Teste1.Models;

namespace Teste1.Controllers
{
    public class CurriculosController : Controller
    {
        private readonly Contexto _context;

        public CurriculosController(Contexto context)
        {
            _context = context;
        }

        // GET: Curriculos
        public async Task<IActionResult> Index()
        {
              return _context.Curriculos != null ? 
                          View(await _context.Curriculos.ToListAsync()) :
                          Problem("Entity set 'Contexto.Curriculos'  is null.");
        }

        // GET: Curriculos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Curriculos == null)
            {
                return NotFound();
            }

            var curriculos = await _context.Curriculos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (curriculos == null)
            {
                return NotFound();
            }

            return View(curriculos);
        }

        // GET: Curriculos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Curriculos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Funcao,Nome,Cidade,Dta_Nasc,Salario,Obs")] Curriculos curriculos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(curriculos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(curriculos);
        }

        // GET: Curriculos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Curriculos == null)
            {
                return NotFound();
            }

            var curriculos = await _context.Curriculos.FindAsync(id);
            if (curriculos == null)
            {
                return NotFound();
            }
            return View(curriculos);
        }

        // POST: Curriculos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Funcao,Nome,Cidade,Dta_Nasc,Salario,Obs")] Curriculos curriculos)
        {
            if (id != curriculos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(curriculos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CurriculosExists(curriculos.Id))
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
            return View(curriculos);
        }

        // GET: Curriculos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Curriculos == null)
            {
                return NotFound();
            }

            var curriculos = await _context.Curriculos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (curriculos == null)
            {
                return NotFound();
            }

            return View(curriculos);
        }

        // POST: Curriculos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Curriculos == null)
            {
                return Problem("Entity set 'Contexto.Curriculos'  is null.");
            }
            var curriculos = await _context.Curriculos.FindAsync(id);
            if (curriculos != null)
            {
                _context.Curriculos.Remove(curriculos);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CurriculosExists(int id)
        {
          return (_context.Curriculos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

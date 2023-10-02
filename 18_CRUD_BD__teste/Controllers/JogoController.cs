using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _18_CRUD_BD.Models;
using _18_CRUD_BD.Context;

namespace _18_CRUD_BD.Controllers
{
    public class JogoController : Controller
    {
        private readonly AppDbContext _context;

        public JogoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Jogo
        public async Task<IActionResult> Index()
        {
              return View(await _context.Jogo.ToListAsync());
        }

        // GET: Jogo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Jogo == null)
            {
                return NotFound();
            }

            var jogo = await _context.Jogo
                .FirstOrDefaultAsync(m => m.JogoID == id);
            if (jogo == null)
            {
                return NotFound();
            }

            return View(jogo);
        }

        // GET: Jogo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Jogo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("JogoID,Nome,Descricao,Imagem,Ativo")] Jogo jogo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jogo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jogo);
        }

        // GET: Jogo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Jogo == null)
            {
                return NotFound();
            }

            var jogo = await _context.Jogo.FindAsync(id);
            if (jogo == null)
            {
                return NotFound();
            }
            return View(jogo);
        }

        // POST: Jogo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("JogoID,Nome,Descricao,Imagem,Ativo")] Jogo jogo)
        {
            if (id != jogo.JogoID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jogo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JogoExists(jogo.JogoID))
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
            return View(jogo);
        }

        // GET: Jogo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Jogo == null)
            {
                return NotFound();
            }

            var jogo = await _context.Jogo
                .FirstOrDefaultAsync(m => m.JogoID == id);
            if (jogo == null)
            {
                return NotFound();
            }

            return View(jogo);
        }

        // POST: Jogo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Jogo == null)
            {
                return Problem("Entity set 'AppDbContex.Jogo'  is null.");
            }
            var jogo = await _context.Jogo.FindAsync(id);
            if (jogo != null)
            {
                _context.Jogo.Remove(jogo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JogoExists(int id)
        {
          return _context.Jogo.Any(e => e.JogoID == id);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcTienda.Models;

namespace MvcTienda.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly MvcTiendaContext _context;
        public CategoriaController(MvcTiendaContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Categoria.ToListAsync());
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Categoria == null)
            {
                return NotFound();
            }

            var variable = await _context.Categoria
                .FirstOrDefaultAsync(m => m.IdCategoria == id);
            if (variable == null)
            {
                return NotFound();
            }

            return View(variable);
        }
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create([Bind("IdCategoria,Nombre,UrlFoto")] Categoria variable)
        {
            if (ModelState.IsValid)
            {
                _context.Add(variable);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(variable);
        }


        public async Task<IActionResult> Edit(int Id)
        {
            var variable = await _context.Categoria.FindAsync(Id);
            return View(variable);
        }
        [HttpPost, ActionName("Edit")]
        public async Task<IActionResult> Edit(int IdCategoria, [Bind("IdCategoria,Nombre,UrlFoto")] Categoria variable)
        {
            variable.IdCategoria = IdCategoria;

            _context.Update(variable);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Categoria == null)
            {
                return NotFound();
            }

            var variable = await _context.Categoria
                .FirstOrDefaultAsync(m => m.IdCategoria == id);
            if (variable == null)
            {
                return NotFound();
            }

            return View(variable);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Categoria == null)
            {
                return Problem("Entity set 'MvcCrudContext.Usuarios'  is null.");
            }
            var variable = await _context.Categoria.FindAsync(id);
            if (variable != null)
            {
                _context.Categoria.Remove(variable);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}

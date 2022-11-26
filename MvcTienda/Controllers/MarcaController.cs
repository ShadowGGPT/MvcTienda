using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcTienda.Models;

namespace MvcTienda.Controllers
{
    public class MarcaController : Controller
    {

        private readonly MvcTiendaContext _context;
        public MarcaController(MvcTiendaContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Marcas.ToListAsync());
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Marcas == null)
            {
                return NotFound();
            }

            var variable = await _context.Marcas
                .FirstOrDefaultAsync(m => m.IdMarca == id);
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
        public async Task<IActionResult> Create([Bind("IdMarca,Nombre,UrlFoto")] Marca variable)
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
            var variable = await _context.Marcas.FindAsync(Id);
            return View(variable);
        }
        [HttpPost, ActionName("Edit")]
        public async Task<IActionResult> Edit(int IdMarca,[Bind("IdMarca,Nombre,UrlFoto")] Marca variable)
        {
            variable.IdMarca = IdMarca;

            _context.Update(variable);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Marcas == null)
            {
                return NotFound();
            }

            var variable = await _context.Marcas
                .FirstOrDefaultAsync(m => m.IdMarca == id);
            if (variable == null)
            {
                return NotFound();
            }

            return View(variable);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Marcas == null)
            {
                return Problem("Entity set 'MvcCrudContext.Usuarios'  is null.");
            }
            var variable = await _context.Marcas.FindAsync(id);
            if (variable != null)
            {
                _context.Marcas.Remove(variable);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}

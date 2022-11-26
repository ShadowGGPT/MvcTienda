using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcTienda.Models;

namespace MvcTienda.Controllers
{
    public class ProductoController : Controller
    {
        private readonly MvcTiendaContext _context;
        public ProductoController(MvcTiendaContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Productos.ToListAsync());
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Productos == null)
            {
                return NotFound();
            }

            var variable = await _context.Productos
                .FirstOrDefaultAsync(m => m.IdProducto == id);
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
        public async Task<IActionResult> Create([Bind("IdProducto,Nombre,Descripcion,IdMarca,IdCategoria,Precio,Stock,UrlFoto")] Producto variable)
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
            var variable = await _context.Productos.FindAsync(Id);
            return View(variable);
        }
        [HttpPost, ActionName("Edit")]
        public async Task<IActionResult> Edit(int IdProducto, [Bind("IdProducto,Nombre,Descripcion,IdMarca,IdCategoria,Precio,Stock,UrlFoto")] Producto variable)
        {
            variable.IdProducto = IdProducto;

            _context.Update(variable);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Productos == null)
            {
                return NotFound();
            }

            var variable = await _context.Productos
                .FirstOrDefaultAsync(m => m.IdProducto == id);
            if (variable == null)
            {
                return NotFound();
            }

            return View(variable);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Productos == null)
            {
                return Problem("Entity set 'MvcCrudContext.Usuarios'  is null.");
            }
            var variable = await _context.Productos.FindAsync(id);
            if (variable != null)
            {
                _context.Productos.Remove(variable);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}

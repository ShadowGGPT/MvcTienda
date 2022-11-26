using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcTienda.Models;

namespace MvcTienda.Controllers
{
    public class ProveedorController : Controller
    {

        private readonly MvcTiendaContext _context;
        public ProveedorController(MvcTiendaContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Proveedors.ToListAsync());
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Proveedors == null)
            {
                return NotFound();
            }

            var variable = await _context.Proveedors
                .FirstOrDefaultAsync(m => m.IdProveedor == id);
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
        public async Task<IActionResult> Create([Bind("IdProveedor,NombreFoto,Telefono,Correo,Direccion,Descripcion")] Proveedor variable)
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
            var variable = await _context.Proveedors.FindAsync(Id);
            return View(variable);
        }
        [HttpPost, ActionName("Edit")]
        public async Task<IActionResult> Edit(int IdProveedor,[Bind("IdProveedor,NombreFoto,Telefono,Correo,Direccion,Descripcion")] Proveedor variable)
        {
            variable.IdProveedor = IdProveedor;

            _context.Update(variable);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Proveedors == null)
            {
                return NotFound();
            }

            var variable = await _context.Proveedors
                .FirstOrDefaultAsync(m => m.IdProveedor == id);
            if (variable == null)
            {
                return NotFound();
            }

            return View(variable);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Proveedors == null)
            {
                return Problem("Entity set 'MvcCrudContext.Usuarios'  is null.");
            }
            var variable = await _context.Proveedors.FindAsync(id);
            if (variable != null)
            {
                _context.Proveedors.Remove(variable);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}

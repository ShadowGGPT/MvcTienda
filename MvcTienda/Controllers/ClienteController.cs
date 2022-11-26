using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcTienda.Models;

namespace MvcTienda.Controllers
{
    public class ClienteController : Controller
    {
        private readonly MvcTiendaContext _context;
        public ClienteController(MvcTiendaContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Clientes.ToListAsync());
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Clientes == null)
            {
                return NotFound();
            }

            var variable = await _context.Clientes
                .FirstOrDefaultAsync(m => m.IdCliente == id);
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
        public async Task<IActionResult> Create([Bind("IdCliente,Nombres,Apellidos,Telefono,Direccion,Correo")] Cliente variable)
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
            var variable = await _context.Clientes.FindAsync(Id);
            return View(variable);
        }
        [HttpPost, ActionName("Edit")]
        public async Task<IActionResult> Edit(int IdCliente, [Bind("IdCliente,Nombres,Apellidos,Telefono,Direccion,Correo")] Cliente variable)
        {
            variable.IdCliente = IdCliente;

            _context.Update(variable);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Clientes == null)
            {
                return NotFound();
            }

            var variable = await _context.Clientes
                .FirstOrDefaultAsync(m => m.IdCliente == id);
            if (variable == null)
            {
                return NotFound();
            }

            return View(variable);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Clientes == null)
            {
                return Problem("Entity set 'MvcCrudContext.Usuarios'  is null.");
            }
            var variable = await _context.Clientes.FindAsync(id);
            if (variable != null)
            {
                _context.Clientes.Remove(variable);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}

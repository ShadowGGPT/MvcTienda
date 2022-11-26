using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcTienda.Models;

namespace MvcTienda.Controllers
{
    public class DashBoardController : Controller
    {
        private readonly MvcTiendaContext _context;
        public DashBoardController(MvcTiendaContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult datos()
        //{
        //    List<int> lista = new List<int> {
        //        _context.Clientes.Count(),
        //        _context.Proveedors.Count(),
        //        _context.Productos.Count(),
        //    _context.Categoria.Count()
        //    };


        //    return StatusCode(StatusCodes.Status200OK,lista);

        //}
    }
}

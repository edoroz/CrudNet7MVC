using CrudNet7MVC.Datos;
using CrudNet7MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CrudNet7MVC.Controllers {
    public class InicioController:Controller {
        private readonly AppDbContext _contexto;

        public InicioController(AppDbContext contexto) {
            _contexto = contexto;
        } //-ctr

        public async Task<IActionResult> Index() {
            return View(await _contexto.Contactos.ToListAsync());
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
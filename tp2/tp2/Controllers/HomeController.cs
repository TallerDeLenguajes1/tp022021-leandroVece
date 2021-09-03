using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using tp2.Models;
using tp2.Views;
using tp2.Views.Home;

namespace tp2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DataEmpleado(string name, string surname,string direc,string DNI, string edad, DateTime Fnacimiento, DateTime FIngreso)
        {

            ViewBag.dni = CError.IsNan(DNI);
            ViewBag.edadIngreso = CError.IsNan(edad);
            ViewBag.nombre = CError.IsAlfab(name);
            ViewBag.apellido = CError.IsAlfab(surname);
            ViewBag.direccion = CError.IsAlfab(direc);

            ViewBag.edad = CEmpleado.Anios(Fnacimiento);
            ViewBag.antiguedad = CEmpleado.Anios(FIngreso);
            ViewBag.salario = CEmpleado.Salario(CEmpleado.Anios(FIngreso));
            //ViewBag.salario2 = CEmpleado.Salario(ViewBag.antiguedad);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}

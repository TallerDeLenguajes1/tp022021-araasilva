using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NLog;
using NLog.Web;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Tp02.Models;

namespace Tp02.Controllers
{
    public class HomeController : Controller
    {
        private readonly Logger _logger;

        public HomeController(ILogger<HomeController> logger, Logger log)
        {
            _logger = log;
            _logger.Debug("NLog injected into HomeController");
        }

        public IActionResult Index()
        {
            _logger.Debug("Hello, this is the index!");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult practico2(string nombre, string apellido, string fechaNacimiento, string direccion, string fechaIngreso)
        {
            try
            {
                if (nombre != null && apellido != null && fechaNacimiento != null && direccion != null && fechaIngreso != null)
                {
                    DateTime fNacimiento = DateTime.Parse(fechaNacimiento);
                    DateTime fIngreso = DateTime.Parse(fechaIngreso);

                    Empleado empleado = new Empleado(nombre, apellido, direccion, fNacimiento, fIngreso);
                    _logger.Info("Datos guardados: " + nombre + " " + apellido + ", " + direccion + ", " + fNacimiento + ", " + fIngreso);
                    ViewBag.Empleado = empleado;
                    return View(empleado);
                }
                else
                {
                    _logger.Error("Se ingresaron campos vacios");
                    ViewBag.mensaje = "Error al ingresar los datos";
                }
            }

            catch (Exception ex)
            {
                _logger.Error(ex.Message);
                ViewBag.mensaje = "Error al procesarse los datos";
            }
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

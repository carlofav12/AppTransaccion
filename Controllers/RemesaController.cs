using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AppTransaccion.Data;
using AppTransaccion.Models;
using AppTransaccion.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AppTransaccion.Controllers
{
    public class RemesaController : Controller
    {
        private readonly ILogger<RemesaController> _logger;
        private readonly ApplicationDbContext _context;

        public RemesaController(ILogger<RemesaController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(RemesaViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Remesa remesa = new Remesa
                {
                    NRemitente = viewModel.FormRemesa.NRemitente,
                    NDestinatario = viewModel.FormRemesa.NDestinatario,
                    PaisOrigen = viewModel.FormRemesa.PaisOrigen,
                    PaisDestino = viewModel.FormRemesa.PaisDestino,
                    MontoOrigen = viewModel.FormRemesa.MontoOrigen,
                    TasaCambio = viewModel.FormRemesa.TasaCambio,
                    MontoDestino = viewModel.FormRemesa.MontoDestino,
                    EstadoTran = viewModel.FormRemesa.EstadoTran
                };

                _context.Add(remesa);
                _context.SaveChanges();

                ViewData["Message"] = "Remesa registrada con éxito!";
                return View("Index");
            }

            return View("Index", viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppTransaccion.ViewModel;
using AppTransaccion.Data;
using AppTransaccion.Models;
using Microsoft.Extensions.Logging;

namespace AppTransaccion.Controllers
{
    public class ListarRemesas : Controller
    {
        private readonly ILogger<ListarRemesas> _logger;
        private readonly ApplicationDbContext _context;

        public ListarRemesas(ILogger<ListarRemesas> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var remesas = _context.DataRemesas.ToList();

            var viewModel = new RemesaViewModel
            {
                ListRemesa = remesas
            };

            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
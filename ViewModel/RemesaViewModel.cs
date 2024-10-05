using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppTransaccion.Models;

namespace AppTransaccion.ViewModel
{
    public class RemesaViewModel
    {
        public Remesa? FormRemesa { get; set; }
        public IEnumerable<Remesa>? ListRemesa { get; set; }
    }
}
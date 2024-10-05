using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppTransaccion.Models
{
    [Table("Remesas")]
    public class Remesa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string NRemitente { get; set; }
        public string NDestinatario { get; set; }
        public string PaisOrigen { get; set; }
        public string PaisDestino { get; set; }
        public double MontoOrigen { get; set; }
        public double TasaCambio { get; set; }
        public double MontoDestino { get; set; }
        public string EstadoTran { get; set; }
    }
}
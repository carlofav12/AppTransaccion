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
        public String Id { get; set; }
        public String NRemitente { get; set; }
        public String NDestinatario { get; set; }
        public String PaisOrigen { get; set; }
        public String PaisDestino { get; set; }
        public double MontoOrigen { get; set; }
        public double TasaCambio { get; set; }
        public double MontoDestino { get; set; }
        public String EstadoTran { get; set; }
    }
}
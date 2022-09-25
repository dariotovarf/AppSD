using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSD.Modelo
{
    public class Descuento
    {
        public string Fecha { get; set; }
        public string Id { get; set; }
        public string Nombre { get; set; }
        public long Base { get; set; }
        public long Retencion { get; set; }
    }
}

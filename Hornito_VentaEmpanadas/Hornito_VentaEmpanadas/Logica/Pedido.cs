using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Pedido
    {
        public int idPedido { get; set; }
        public string formaPago { get; set; }
        public int cantEmpanada { get; set; }
        public string estado { get; set; }
        public int precioTotal { get; set; }
        public int demora { get; set; }
        
        public string nomCliente { get; set; } 
    }
}

using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAServicios_TSMV.CapaEntidades
{
    class ESoldado
    {
        private int idsoldado;
        private string nombre;
        private string apellido;
        private string dni;
        private string numeroplaca;
        private DateTime fecha;
        public int Idsoldado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Numeroplaca { get; set; }
        public DateTime Fecha { get; set; }
    }
}

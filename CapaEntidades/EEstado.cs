using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAServicios_TSMV.CapaEntidades
{
    class EEstado
    {
        private int idestado;
        private string estado;
        private string motivo;
        private string fecha;
        private int idsoldado;
        public int Idestado { get; set; }
        public string Estado { get; set; }
        public string Motivo { get; set; }
        public string Fecha { get; set; }
        public int Idsoldado { get; set; }
    }
}

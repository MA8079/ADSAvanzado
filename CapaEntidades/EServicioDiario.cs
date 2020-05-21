using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAServicios_TSMV.CapaEntidades
{
    class EServicioDiario
    {
        private int idserviciodiario;
        private int idsoldado;
        private int idservicio;
        private int idturno;
        private string fecha;
        public int Idserviciodiario { get; set; }
        public int Idsoldado { get; set; }
        public int Idservicio { get; set; }
        public int Idturno { get; set; }
        public string Fecha { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAServicios_TSMV.CapaEntidades
{
    class EServicioSemana
    {
        private int idserviciosemanal;
        private int idsoldado;
        private int idservicio;
        private string fechainicio;
        private string fechafinalizacion;
        public int Idserviciosemanal { get; set; }
        public int Idsoldado { get; set; }
        public int Idservicio { get; set; }
        public string Fechainicio { get; set; }
        public string Fechafinalizacion { get; set; }
    }
}

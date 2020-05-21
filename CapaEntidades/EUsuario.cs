using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAServicios_TSMV.CapaEntidades
{
    class EUsuario
    {
        private int idusuario;
        private string nombreusuario;
        private string contrasenia;
        private string tipo;
        public int Idusuario { get; set; }
        public string Nombreusuario { get; set; }
        public string Contrasenia { get; set; }
        public string Tipo { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAServicios_TSMV.CapaEntidades;

namespace SAServicios_TSMV.CapaInterfaces
{
    interface IEstado
    {
        void RegistrarEstado(EEstado eEstado);
        void EliminarEstado(EEstado eEstado);
        void ModificarEstado(EEstado eEstado);
        void MEConfigurado(EEstado eEstado);
        DataTable ListarEstado(EEstado eEstado);
        int ObtenerID(int idsoldado);
    }
}

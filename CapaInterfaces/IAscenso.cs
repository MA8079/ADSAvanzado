using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAServicios_TSMV.CapaEntidades;
using System.Data;

namespace SAServicios_TSMV.CapaInterfaces
{
    interface IAscenso
    {
        void RegistrarAscenso(EAscenso eAscenso);
        void ModificarAscenso(EAscenso eAscenso);
        void EliminarAscenso(EAscenso eAscenso);
        DataTable CargarAscenso();
    }
}

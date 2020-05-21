using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAServicios_TSMV.CapaEntidades;


namespace SAServicios_TSMV.CapaInterfaces
{
    interface IPromocion
    {
        DataTable ListarPromocion();
        void RegistrarPromocion(EPromocion ePromocion);
        void ModificarPromocion(EPromocion ePromocion);
        void BorrarPromocion(EPromocion ePromocion);
    }
}

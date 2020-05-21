using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAServicios_TSMV.CapaEntidades;

namespace SAServicios_TSMV.CapaInterfaces
{
    interface IUsuario
    {
        DataTable ListarUsuarios();
        void EliminarUsuario(EUsuario eUsuario);
        void RegistrarUsuario(EUsuario eUsuario);
        void ModificarUsuario(EUsuario eUsuario);
        DataTable ValidarLogin(EUsuario eUsuario);
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAServicios_TSMV.CapaAcceso;
using SAServicios_TSMV.CapaEntidades;
using SAServicios_TSMV.CapaInterfaces;
using SAServicios_TSMV.CapaComun.Cache;

namespace SAServicios_TSMV.CapaLogica
{
    class LUsuario : IUsuario
    {
        Datos ADatos = new Datos();
        public void EliminarUsuario(EUsuario eUsuario)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@id",eUsuario.Idusuario));
            ADatos.EliminarRegistro("Delete from TUsuarios where IdUsuario=@id",parametros);
        }

        public DataTable ListarUsuarios()
        {
            DataTable Tabla = ADatos.EjecutarVista("Select * from VUsuarios");
            return Tabla;
        }

        public void ModificarUsuario(EUsuario eUsuario)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@id",eUsuario.Idusuario));
            parametros.Add(new SqlParameter("@nombre", eUsuario.Nombreusuario));
            parametros.Add(new SqlParameter("@contraseña", eUsuario.Contrasenia));
            parametros.Add(new SqlParameter("@tipo", eUsuario.Tipo));
            ADatos.ModificarRegistro("Update TUsuarios set NombreUsuario=@nombre,Contraseña=@contraseña,Tipo=@tipo where IdUsuario=@id",parametros);
        }

        public void RegistrarUsuario(EUsuario eUsuario)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();           
            parametros.Add(new SqlParameter("@nombre", eUsuario.Nombreusuario));
            parametros.Add(new SqlParameter("@contraseña", eUsuario.Contrasenia));
            parametros.Add(new SqlParameter("@tipo", eUsuario.Tipo));
            ADatos.EjecutarRegistro("Insert into TUsuarios values(@nombre,@contraseña,@tipo)",parametros);
        }

        public DataTable ValidarLogin(EUsuario eUsuario)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@username",eUsuario.Nombreusuario));
            parametros.Add(new SqlParameter("@pass",eUsuario.Contrasenia));
            DataTable Tabla=ADatos.EjecutarLectura("Select * from TUsuarios where NombreUsuario=@username and Contraseña=@pass",parametros);
            CacheUserLogin.IdUsuario = int.Parse(Tabla.Rows[0][0].ToString());
            CacheUserLogin.Nombre = Tabla.Rows[0][1].ToString();
            CacheUserLogin.Tipo = Tabla.Rows[0][3].ToString();
            return Tabla;

        }
    }
}

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

namespace SAServicios_TSMV.CapaLogica
{
    class LAscenso : IAscenso
    {
        Datos ADatos = new Datos();

        public DataTable CargarAscenso()
        {
            DataTable Tabla = ADatos.EjecutarVista("Select * from VAscensos");
            return Tabla;
        }

        public void EliminarAscenso(EAscenso eAscenso)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@Id",eAscenso.Idascenso));
            ADatos.EliminarRegistro("Delete from TAscensos where IdAscenso=@Id",parametros);
        }

        public void ModificarAscenso(EAscenso eAscenso)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@id",eAscenso.Idascenso));
            parametros.Add(new SqlParameter("@fecha",eAscenso.Fecha));
            parametros.Add(new SqlParameter("@grado", eAscenso.Grado));
            parametros.Add(new SqlParameter("@idsoldado",eAscenso.Idsoldado));
            ADatos.ModificarRegistro("Update TAscensos set Fecha =@fecha, Grado =@grado, Idsoldado =@idsoldado where IdAscenso =@id",parametros);
        }

        public void RegistrarAscenso(EAscenso eAscenso)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@fecha", eAscenso.Fecha));
            parametros.Add(new SqlParameter("@grado", eAscenso.Grado));
            parametros.Add(new SqlParameter("@idsoldado", eAscenso.Idsoldado));
            ADatos.EjecutarRegistro("Insert into TAscensos values(@fecha,@grado,@idsoldado)", parametros);
        }
    }
}

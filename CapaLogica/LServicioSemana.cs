using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAServicios_TSMV.CapaAcceso;
using SAServicios_TSMV.CapaEntidades;
using SAServicios_TSMV.CapaInterfaces;

namespace SAServicios_TSMV.CapaLogica
{
    class LServicioSemana : IServicioSemanal
    {
        Datos ADatos = new Datos();
        public void EliminarServicio(EServicioSemana eServicioSemana)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@id",eServicioSemana.Idserviciosemanal));
            ADatos.EliminarRegistro("Delete from TServicioSemanales where IdServicioSemanal=@id",parametros);
        }

        public DataTable ListarServicioSemanal()
        {
            DataTable Tabla = ADatos.EjecutarVista("Select * from ReporteServicioSemanal");
            return Tabla;
        }

        public void ListarServicioSemanal(ComboBox combo)
        {
            DataTable Data = ADatos.EjecutarLectura("Select * from TServicios where Tipo='Semanal'");
            combo.DataSource = Data;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "IdServicio";
        }

        public void ModificarServicio(EServicioSemana eServicioSemana)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@id",eServicioSemana.Idserviciosemanal));            
            parametros.Add(new SqlParameter("@idservicio",eServicioSemana.Idservicio));
            parametros.Add(new SqlParameter("@fechainicio",eServicioSemana.Fechainicio));
            parametros.Add(new SqlParameter("@fechafinal",eServicioSemana.Fechafinalizacion));
            ADatos.EjecutarRegistro("Update TServicioSemanales set Idservicio=@idservicio,FechaInicio=@fechainicio,FechaFinalizacion=@fechafinal where IdServicioSemanal=@id",parametros);
        }

        public void RegistrarServicio(EServicioSemana eServicioSemana)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idsoldado", eServicioSemana.Idsoldado));
            parametros.Add(new SqlParameter("@idservicio", eServicioSemana.Idservicio));
            parametros.Add(new SqlParameter("@fechainicio", eServicioSemana.Fechainicio));
            parametros.Add(new SqlParameter("@fechafinal", eServicioSemana.Fechafinalizacion));
            ADatos.EjecutarRegistro("Insert into TServicioSemanales values(@idsoldado,@idservicio,@fechainicio,@fechafinal)", parametros);        
    }
    }
}

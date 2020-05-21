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
    class LServicio : IServicio
    {
        Datos ADatos = new Datos();
        public void EliminarServicio(EServicio eServicio)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@id", eServicio.Idservicio));
            ADatos.EliminarRegistro("Delete from TServicios where IdServicio=@id", parametros);
        }

        public DataTable ListarServicio()
        {
            DataTable Tabla = ADatos.EjecutarVista("Select * from VServicios");
            return Tabla;
        }

        public void ListarServicio(ComboBox combo)
        {
            DataTable Tabla = ADatos.EjecutarVista("Select * from VServicios");
            combo.DataSource = Tabla;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "IdServicio";
        }

        
        public void ModificarServicio(EServicio eServicio)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@id", eServicio.Idservicio));
            parametros.Add(new SqlParameter("@nombre", eServicio.Nombre));
            parametros.Add(new SqlParameter("@tipo", eServicio.Tipo));
            ADatos.ModificarRegistro("Update TServicios set Nombre=@nombre,Tipo=@tipo where IdServicio=@id", parametros);
        }

        public void RegistrarServicio(EServicio eServicio)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@nombre", eServicio.Nombre));
            parametros.Add(new SqlParameter("@tipo", eServicio.Tipo));
            ADatos.EjecutarRegistro("Insert into TServicios values(@nombre,@tipo)", parametros);
        }
    }
}

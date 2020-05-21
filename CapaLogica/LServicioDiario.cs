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
    class LServicioDiario : IServicioDiario
    {
        Datos ADatos = new Datos();
        public void EliminarServicioDiario(EServicioDiario eServicioDiario)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@id",eServicioDiario.Idserviciodiario));
            ADatos.EliminarRegistro("Delete from TServicioDiarios where IdServicioDiario=@id",parametros);
        }

        public void ListarServicioDiario(ComboBox combo)
        {
            DataTable Data = ADatos.EjecutarLectura("Select * from TServicios where Tipo='Diario'");
            combo.DataSource = Data;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "IdServicio";
        }

        public DataTable ListarServicioDiario()
        {
            DataTable Tabla = ADatos.EjecutarVista("Select * from ReporteServicioDiario order by Fecha desc");
            return Tabla;
        }

        public void ModificarServicioDiario(EServicioDiario eServicioDiario)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@turno",eServicioDiario.Idturno));
            parametros.Add(new SqlParameter("@id",eServicioDiario.Idserviciodiario));
            ADatos.ModificarRegistro("Update TServicioDiarios set Idturno=@turno where IdServicioDiario=@id",parametros);
            
        }

        public void RegistrarServicioDiario(EServicioDiario eServicioDiario)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();            
            parametros.Add(new SqlParameter("@idsoldado", eServicioDiario.Idsoldado));
            parametros.Add(new SqlParameter("@idservicio", eServicioDiario.Idservicio));
            parametros.Add(new SqlParameter("@idturno", eServicioDiario.Idturno));
            parametros.Add(new SqlParameter("@fecha", eServicioDiario.Fecha));
            ADatos.EjecutarRegistro("Insert into TServicioDiarios values(@idsoldado,@idservicio,@idturno,@fecha)",parametros);
        }
    }
}

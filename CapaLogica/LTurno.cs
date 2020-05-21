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
    class LTurno : ITurno
    {
        Datos ADatos = new Datos();
        public void EliminarTurno(ETurno eTurno)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@id",eTurno.Idturno));
            ADatos.EliminarRegistro("Delete from TTurnos where IdTurno=@id",parametros);
        }

        public DataTable ListarTurno()
        {
            DataTable Tabla= ADatos.EjecutarVista("Select * from VTurnos");
            return Tabla;
        }

        public void ListarTurno(ComboBox combo)
        {
            DataTable Data = ADatos.EjecutarVista("Select * from VTurnos");
            combo.DataSource = Data;
            combo.DisplayMember = "HoraInicio";
            combo.ValueMember = "IdTurno";
        }

        public void ModificarTurno(ETurno eTurno)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@id",eTurno.Idturno));
            parametros.Add(new SqlParameter("@nombre",eTurno.Nombre));
            parametros.Add(new SqlParameter("@horainicio",eTurno.Horainicio));
            parametros.Add(new SqlParameter("@horafinal",eTurno.Horafinal));
            ADatos.ModificarRegistro("Update TTurnos set Nombre=@nombre,HoraInicio=@horainicio,HoraFinalizacion=@horafinal where IdTurno=@id",parametros );
        }

        public void RegistrarTurno(ETurno eTurno)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@nombre", eTurno.Nombre));
            parametros.Add(new SqlParameter("@horainicio", eTurno.Horainicio));
            parametros.Add(new SqlParameter("@horafinal", eTurno.Horafinal));
            ADatos.EjecutarRegistro("Insert into TTurnos values(@nombre,@horainicio,@horafinal)",parametros);
        }
    }
}

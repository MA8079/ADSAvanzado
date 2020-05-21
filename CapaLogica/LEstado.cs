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
    class LEstado : IEstado
    {
        Datos ADatos = new Datos();
        public void EliminarEstado(EEstado eEstado)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@id",eEstado.Idestado));
            ADatos.EliminarRegistro("Delete from TEstados where IdEstado=@id",parametros);
        }

        public DataTable ListarEstado(EEstado eEstado)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@fecha",eEstado.Fecha));
            DataTable Tabla = ADatos.EjecutarLectura("Select * from VEstados where Fecha=@fecha order by Soldado ASC",parametros);
            return Tabla;
        }

        public void MEConfigurado(EEstado eEstado)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@estado",eEstado.Estado));
            parametros.Add(new SqlParameter("@motivo",eEstado.Motivo));
            parametros.Add(new SqlParameter("@fecha",eEstado.Fecha));
            parametros.Add(new SqlParameter("@idsoldado",eEstado.Idsoldado));
            ADatos.ModificarRegistro("Update TEstados set Estado=@estado,Motivo=@motivo where Fecha=@fecha and Idsoldado=@idsoldado",parametros);
        }

        public void ModificarEstado(EEstado eEstado)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@id",eEstado.Idestado));
            parametros.Add(new SqlParameter("@estado",eEstado.Estado));
            parametros.Add(new SqlParameter("@motivo",eEstado.Motivo));
            parametros.Add(new SqlParameter("@fecha",eEstado.Fecha));            
            parametros.Add(new SqlParameter("@idsoldado",eEstado.Idsoldado));
            String Query = "Update TEstados set Estado =@estado,Motivo =@motivo,Fecha =@fecha," +
                            "Idsoldado =@idsoldado where IdEstado =@id";
            ADatos.ModificarRegistro(Query, parametros);            
        }

        public int ObtenerID(int idsoldado)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@id",idsoldado));
            DataTable Tabla=ADatos.EjecutarLectura("Select IdEstado from TEstados where Idsoldado=@id",parametros);
            int IDestado = int.Parse(Tabla.Rows[0][0].ToString());
            return IDestado;
        }

        public void RegistrarEstado(EEstado eEstado)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            
            parametros.Add(new SqlParameter("@estado", eEstado.Estado));
            parametros.Add(new SqlParameter("@motivo", eEstado.Motivo));
            parametros.Add(new SqlParameter("@fecha", eEstado.Fecha));
            parametros.Add(new SqlParameter("@idsoldado", eEstado.Idsoldado));
            ADatos.EjecutarRegistro("Insert into TEstados values(@estado,@motivo,@fecha,@idsoldado)",parametros);

        }
    }
}

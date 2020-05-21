using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAServicios_TSMV.CapaEntidades;
using SAServicios_TSMV.CapaInterfaces;
using SAServicios_TSMV.CapaAcceso;
using System.Data.SqlClient;

namespace SAServicios_TSMV.CapaLogica
{
    class LPromocion : IPromocion
    {
        Datos ADatos = new Datos();
        public void BorrarPromocion(EPromocion ePromocion)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@id",ePromocion.Idpromocion));
            ADatos.EliminarRegistro("Delete from TPromciones where IdPromocion=@id",parametros);
        }

        public DataTable ListarPromocion()
        {
            DataTable Tabla= ADatos.EjecutarVista("Select * from VPromociones");
            return Tabla;
        }

        public void ModificarPromocion(EPromocion ePromocion)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@id", ePromocion.Idpromocion));
            parametros.Add(new SqlParameter("@año", ePromocion.Anio));
            parametros.Add(new SqlParameter("@mes",ePromocion.Mes));
            parametros.Add(new SqlParameter("@idsoldado",ePromocion.Idsoldado));
            ADatos.ModificarRegistro("Update TPromociones set Año=@año,Mes=@mes,Idsoldado=@idsoldado where IdPromocion=@id",parametros);

        }

        public void RegistrarPromocion(EPromocion ePromocion)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();            
            parametros.Add(new SqlParameter("@año", ePromocion.Anio));
            parametros.Add(new SqlParameter("@mes", ePromocion.Mes));
            parametros.Add(new SqlParameter("@idsoldado", ePromocion.Idsoldado));
            ADatos.EjecutarRegistro("Insert into TPromociones values(@año,@mes,@idsoldado)",parametros);
        }
    }
}

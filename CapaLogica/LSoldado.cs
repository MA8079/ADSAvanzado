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
    class LSoldado : ISoldado
    {
        Datos ADatos = new Datos();
        public void EliminarSoldado(ESoldado eSoldado)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@id",eSoldado.Idsoldado));
            ADatos.EliminarRegistro("Delete from TSoldados where IdSoldado=@id",parametros);
        }

        public DataTable ListarSoldado()
        {
            DataTable Tabla = ADatos.EjecutarVista("Select * from VSoldados order by Apellido ASC");
            return Tabla;
        }

        public void ListarPorGrado(ComboBox combo,String grado)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@grado",grado));
            DataTable data = ADatos.EjecutarLectura("Select * from ListaPorGrado where Grado=@grado", parametros);
            combo.DataSource = data;
            combo.DisplayMember = "Apellido"; //Valor a mostrar
            combo.ValueMember = "IdSoldado"; //Valor a utilizar

        }

        //Listar soldados disponibles del presente día para servicio diario y semanal:ComboBox
        public void SoldadoDisponible(ComboBox combo)
        {
            
            String estado = "Disponible";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@estado",estado));
            parametros.Add(new SqlParameter("fecha",DateTime.Now.ToString("yyyy-MM-dd")));
            DataTable Tabla = ADatos.EjecutarLectura("Select IDS,Soldado from VEstados where Estado=@estado and Fecha=@fecha order by Soldado ASC",parametros);
            combo.DataSource = Tabla;
            combo.DisplayMember = "Soldado";
            combo.ValueMember = "IDS";
        }

        //Listar soldados disponibles del presente día para servicio diario y semanal: DataGridView
        public DataTable SoldadoDisponible()
        {
            String estado = "Disponible";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@estado",estado));
            parametros.Add(new SqlParameter("@fecha",DateTime.Now.ToString("yyyy-MM-dd")));
            DataTable Tabla = ADatos.EjecutarLectura("Select IDS,Grado,Soldado,Estado,Fecha from VEstados where Estado=@estado and Fecha=@fecha order by Soldado ASC",parametros);
            return Tabla;
        }

        public void ModificarSoldado(ESoldado eSoldado)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@id",eSoldado.Idsoldado));
            parametros.Add(new SqlParameter("@nombre",eSoldado.Nombre));
            parametros.Add(new SqlParameter("@apellido",eSoldado.Apellido));
            parametros.Add(new SqlParameter("@dni",eSoldado.Dni));
            parametros.Add(new SqlParameter("@placa",eSoldado.Numeroplaca));
            ADatos.ModificarRegistro("Update TSoldados set Nombre=@nombre,Apellido=@apellido,DNI=@dni,NumeroPlaca=@placa where IdSoldado=@id",parametros);
        }

        public void RegistrarSoldado(ESoldado eSoldado)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@nombre", eSoldado.Nombre));
            parametros.Add(new SqlParameter("@apellido", eSoldado.Apellido));
            parametros.Add(new SqlParameter("@dni", eSoldado.Dni));
            parametros.Add(new SqlParameter("@placa", eSoldado.Numeroplaca));
            parametros.Add(new SqlParameter("@fecha",eSoldado.Fecha));
            ADatos.EjecutarRegistro("Insert into TSoldados values(@nombre,@apellido,@dni,@placa,@fecha)",parametros);
        }

        public void ListarSoldado(ComboBox combo)
        {
            DataTable Data = ADatos.EjecutarLectura("Select * from VSoldados");
            combo.DataSource = Data;
            combo.DisplayMember = "Apellido";
            combo.ValueMember = "IdSoldado";
        }

        public int ObtenerID(string condicion)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@apellido",condicion));
            DataTable Tabla= ADatos.EjecutarLectura("Select IdSoldado from TSoldados where Apellido=@apellido",parametros);
            int ID =int.Parse(Tabla.Rows[0][0].ToString());
            return ID;
        }

        public void ListarSoldado(CheckedListBox checkedList)
        {
            DataTable Tabla = ADatos.EjecutarLectura("Select * from VSoldados");
            checkedList.DataSource = Tabla;
            checkedList.DisplayMember = "Apellido";
            checkedList.ValueMember = "ID";
        }
    }
}

using SAServicios_TSMV.CapaEntidades;
using SAServicios_TSMV.CapaInterfaces;
using SAServicios_TSMV.CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAServicios_TSMV.CapaPresentacion
{
    public partial class FormServicioDiario : Form
    {
        
        public FormServicioDiario()
        {
            InitializeComponent();
            ListarPersonalDisponible();
            ListarServicioDiario();

            CargarServicio();
            CargarSoldado();
            CargarTurno();
            
        }



        #region Metodos de Inicio
        private void CargarTurno()
        {
            ITurno turno = new LTurno();
            turno.ListarTurno(Cbturno);
        }
        private void CargarSoldado()
        {
            ISoldado soldado = new LSoldado();
            soldado.SoldadoDisponible(Cbsoldado);
        }
        private void CargarServicio()
        {
            IServicioDiario diario = new LServicioDiario();
            diario.ListarServicioDiario(Cbservicio);
        }
        private void ListarPersonalDisponible()
        {
            ISoldado soldado = new LSoldado();
            DataTable Tabla = soldado.SoldadoDisponible();
            DGVSold_Disponible.DataSource =Tabla;
        }
        private void ListarServicioDiario()
        {
            IServicioDiario sd = new LServicioDiario();
            DGVServ_Diario.DataSource=sd.ListarServicioDiario();
        }
        #endregion


        


        #region Metodos de cambio de estado y ID
        private void EstadoNoDisponible()
        {
            EEstado estado = new EEstado();
            estado.Idestado = ObtenerIdEstado();
            estado.Estado = "No Disponible";
            estado.Motivo = Cbservicio.Text;
            estado.Fecha = DTFecha.Value.ToString("yyyy-MM-dd");
            estado.Idsoldado = int.Parse(Cbsoldado.SelectedValue.ToString());
            IEstado l_estado = new LEstado();
            l_estado.ModificarEstado(estado);
        }
        private void EstadoDisponible(String Apellido)
        {
            ISoldado soldado = new LSoldado();            
            EEstado estado = new EEstado();                       
            estado.Estado = "Disponible";
            estado.Motivo = "S/N";
            estado.Fecha = DateTime.Now.ToString("yyyy-MM-dd");
            estado.Idsoldado = soldado.ObtenerID(Apellido);
            IEstado l_estado = new LEstado();
            l_estado.MEConfigurado(estado);
        }
        private int ObtenerIdEstado()
        {
            //Cuando el soldado es asignado a un servicio.
            IEstado estado = new LEstado();
            return estado.ObtenerID(int.Parse(Cbsoldado.SelectedValue.ToString()));

        }
        #endregion

        private void DGVServ_Diario_MouseCaptureChanged(object sender, EventArgs e)
        {
            //Desactivar con boton borrador.
            TbApellido.Visible = true;
            BtnModificar.Enabled = true;
            BtnEliminar.Enabled = true;
            BtnGuardar.Enabled = false;
            

            Tbid.Text = DGVServ_Diario.Rows[DGVServ_Diario.CurrentRow.Index].Cells[0].Value.ToString();
            TbApellido.Text= DGVServ_Diario.Rows[DGVServ_Diario.CurrentRow.Index].Cells[1].Value.ToString();
            Cbservicio.Text= DGVServ_Diario.Rows[DGVServ_Diario.CurrentRow.Index].Cells[2].Value.ToString();
            Cbturno.SelectedText=DGVServ_Diario.Rows[DGVServ_Diario.CurrentRow.Index].Cells[3].Value.ToString();            
            DTFecha.Value=Convert.ToDateTime(DGVServ_Diario.Rows[DGVServ_Diario.CurrentRow.Index].Cells[4].Value.ToString());
        }


        #region Programacion de Botones
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            EstadoDisponible(TbApellido.Text);
            EServicioDiario diario = new EServicioDiario();
            diario.Idserviciodiario = int.Parse(Tbid.Text);
            IServicioDiario ldiario = new LServicioDiario();
            ldiario.EliminarServicioDiario(diario);

            ListarServicioDiario();
            ListarPersonalDisponible();
            CargarSoldado();

            TbApellido.Clear();
            
            
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Tbid.Clear();
            TbApellido.Clear();
            TbApellido.Visible = false;            
            

            Cbsoldado.Visible = true;
            BtnGuardar.Enabled = true;
            BtnEliminar.Enabled = false;
            BtnModificar.Enabled = false;

            DTFecha.ResetText();
            DGVServ_Diario.ClearSelection();
        }


        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            EServicioDiario diario = new EServicioDiario();
            diario.Idsoldado = int.Parse(Cbsoldado.SelectedValue.ToString());
            diario.Idservicio = int.Parse(Cbservicio.SelectedValue.ToString());
            diario.Idturno = int.Parse(Cbturno.SelectedValue.ToString());
            diario.Fecha = DTFecha.Value.ToString("yyyy-MM-dd");
            IServicioDiario servicio = new LServicioDiario();
            servicio.RegistrarServicioDiario(diario);
            EstadoNoDisponible();
            ListarPersonalDisponible();
            CargarSoldado();
            ListarServicioDiario();
            
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            EServicioDiario diario = new EServicioDiario();
            diario.Idserviciodiario = int.Parse(Tbid.Text);
            diario.Idturno = int.Parse(Cbturno.SelectedValue.ToString());
            IServicioDiario lsd = new LServicioDiario();
            lsd.ModificarServicioDiario(diario);
            ListarServicioDiario();
        }


        #endregion


    }
}

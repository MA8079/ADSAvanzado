using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAServicios_TSMV.CapaEntidades;
using SAServicios_TSMV.CapaInterfaces;
using SAServicios_TSMV.CapaLogica;

namespace SAServicios_TSMV.CapaPresentacion
{
    public partial class FormServicioSemana : Form
    {
        public FormServicioSemana()
        {
            InitializeComponent();

            CargarSoldado();
            CargarServicio();
            ListarSoldadoDisponible();
            ListarServicioSemanal();

        }



        #region Metodos de Inicio
        private void ListarServicioSemanal()
        {
            IServicioSemanal SS = new LServicioSemana();
            DGVServ_Semana.DataSource = SS.ListarServicioSemanal();
        }
        private void ListarSoldadoDisponible()
        {
            ISoldado soldado = new LSoldado();
            DataTable Tabla = soldado.SoldadoDisponible();
            DGVSold_Disponible.DataSource = Tabla;
        }

        private void CargarServicio()
        {
            IServicioSemanal SS = new LServicioSemana();
            SS.ListarServicioSemanal(Cbservicio);
        }

        private void CargarSoldado()
        {
            ISoldado soldado = new LSoldado();
            soldado.SoldadoDisponible(Cbsoldado);
        }
        #endregion

        #region Cambios de Estado y Obtener ID
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

        private void EstadoNoDisponible()
        {
            EEstado estado = new EEstado();
            estado.Idestado = ObtenerIdEstado();
            estado.Estado = "No Disponible";
            estado.Motivo = Cbservicio.Text;
            estado.Fecha = DTinicio.Value.ToString("yyyy-MM-dd");
            estado.Idsoldado = int.Parse(Cbsoldado.SelectedValue.ToString());
            IEstado l_estado = new LEstado();
            l_estado.ModificarEstado(estado);
        }
        private int ObtenerIdEstado()
        {
            //Cuando el soldado es asignado a un servicio.
            IEstado estado = new LEstado();
            return estado.ObtenerID(int.Parse(Cbsoldado.SelectedValue.ToString()));

        }

        #endregion


        #region Promgramación de Botones y DataGridView
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            EServicioSemana OSS = new EServicioSemana();
            OSS.Idsoldado = int.Parse(Cbsoldado.SelectedValue.ToString());
            OSS.Idservicio = int.Parse(Cbservicio.SelectedValue.ToString());
            OSS.Fechainicio = DTinicio.Value.ToString("yyyy-MM-dd");
            OSS.Fechafinalizacion = DTfin.Value.ToString("yyyy-MM-dd");
            IServicioSemanal LogSS = new LServicioSemana();
            LogSS.RegistrarServicio(OSS);
            EstadoNoDisponible();
            ListarSoldadoDisponible();
            CargarSoldado();
            ListarServicioSemanal();
        }
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            EServicioSemana OSS = new EServicioSemana();
            OSS.Idserviciosemanal = int.Parse(Tbid.Text);
            OSS.Idservicio = int.Parse(Cbservicio.SelectedValue.ToString());
            OSS.Fechainicio = DTinicio.Value.ToString("yyyy-MM-dd");
            OSS.Fechafinalizacion = DTfin.Value.ToString("yyyy-MM-dd");
            IServicioSemanal LSS = new LServicioSemana();
            LSS.ModificarServicio(OSS);
            ListarServicioSemanal();
            DGVServ_Semana.ClearSelection();
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            EstadoDisponible(Tbapellido.Text);
            EServicioSemana SS = new EServicioSemana();
            SS.Idserviciosemanal = int.Parse(Tbid.Text);
            IServicioSemanal ISS = new LServicioSemana();
            ISS.EliminarServicio(SS);

            ListarServicioSemanal();
            ListarSoldadoDisponible();
            CargarSoldado();

            Tbapellido.Clear();
            DGVServ_Semana.ClearSelection();
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Tbid.Clear();
            Tbapellido.Clear();
            Tbapellido.Visible = false;

            BtnEliminar.Enabled = false;
            BtnModificar.Enabled = false;
            BtnGuardar.Enabled = true;

            DGVSold_Disponible.ClearSelection();
            DGVServ_Semana.ClearSelection();
        }
        private void DGVServ_Semana_MouseCaptureChanged(object sender, EventArgs e)
        {
            Tbapellido.Visible = true;
            BtnModificar.Enabled = true;
            BtnEliminar.Enabled = true;
            BtnGuardar.Enabled = false;

            Tbid.Text = DGVServ_Semana.Rows[DGVServ_Semana.CurrentRow.Index].Cells[0].Value.ToString();
            Tbapellido.Text = DGVServ_Semana.Rows[DGVServ_Semana.CurrentRow.Index].Cells[1].Value.ToString();
            Cbservicio.Text = DGVServ_Semana.Rows[DGVServ_Semana.CurrentRow.Index].Cells[2].Value.ToString();
            DTinicio.Value = Convert.ToDateTime(DGVServ_Semana.Rows[DGVServ_Semana.CurrentRow.Index].Cells[3].Value.ToString());
            DTfin.Value = Convert.ToDateTime(DGVServ_Semana.Rows[DGVServ_Semana.CurrentRow.Index].Cells[4].Value.ToString());

        }

        #endregion


    }
}

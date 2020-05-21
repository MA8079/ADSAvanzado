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
    public partial class FormServicio : Form
    {
        public FormServicio()
        {
            InitializeComponent();
            ListarServicio();
            CargarTipo();
        }

        private void CargarTipo()
        {
            Cbtipo.Items.Add("Diario");
            Cbtipo.Items.Add("Semanal");
        }

        private void ListarServicio()
        {
            IServicio servicio = new LServicio();
            DataTable Tabla = servicio.ListarServicio();
            DGVServicio.DataSource = Tabla;

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            EServicio servicio = new EServicio();
            servicio.Nombre = Tbnombre.Text;
            servicio.Tipo = Cbtipo.SelectedItem.ToString();
            IServicio lservicio = new LServicio();
            lservicio.RegistrarServicio(servicio);
            ListarServicio();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            EServicio servicio = new EServicio();
            servicio.Idservicio =int.Parse(Tbid.Text);
            servicio.Nombre = Tbnombre.Text;
            servicio.Tipo = Cbtipo.SelectedItem.ToString();
            IServicio lservicio = new LServicio();
            lservicio.ModificarServicio(servicio);
            ListarServicio();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            EServicio servicio = new EServicio();
            servicio.Idservicio = int.Parse(Tbid.Text);
            IServicio lservicio = new LServicio();
            lservicio.EliminarServicio(servicio);
            ListarServicio();
        }

        private void DGVServicio_MouseCaptureChanged(object sender, EventArgs e)
        {
            BtnModificar.Enabled = true;
            Tbid.Text = DGVServicio.Rows[DGVServicio.CurrentRow.Index].Cells[0].Value.ToString();
            Tbnombre.Text = DGVServicio.Rows[DGVServicio.CurrentRow.Index].Cells[1].Value.ToString();
            Cbtipo.Text = DGVServicio.Rows[DGVServicio.CurrentRow.Index].Cells[2].Value.ToString();
        }

        private void Icono_Click(object sender, EventArgs e)
        {
            Tbid.Clear();
            Tbnombre.Clear();
            BtnModificar.Enabled = false;
            DGVServicio.ClearSelection();
        }
    }
}

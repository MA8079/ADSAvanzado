using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAServicios_TSMV.CapaLogica;
using SAServicios_TSMV.CapaEntidades;
using SAServicios_TSMV.CapaInterfaces;

namespace SAServicios_TSMV.CapaPresentacion
{
    public partial class FormPromocion : Form
    {
        public FormPromocion()
        {
            InitializeComponent();
            ListarPromocion();
            CargarMes();
        }

        private void ListarPromocion()
        {
            IPromocion L_promocion = new LPromocion();
            DataTable Tabla=L_promocion.ListarPromocion();
            DGVPromocion.DataSource = Tabla;
        }
        private void CargarMes()
        {
            CbMes.Items.Add("Enero");
            CbMes.Items.Add("Julio");
        }
        private void DGVPromocion_MouseCaptureChanged(object sender, EventArgs e)
        {
            
            BtnModificar.Enabled = true;
            TbId.Text =DGVPromocion.Rows[DGVPromocion.CurrentRow.Index].Cells[0].Value.ToString();
            CbMes.Text= DGVPromocion.Rows[DGVPromocion.CurrentRow.Index].Cells[4].Value.ToString();
            TbAnio.Text = DGVPromocion.Rows[DGVPromocion.CurrentRow.Index].Cells[5].Value.ToString();
            TbIdSoldado.Text=DGVPromocion.Rows[DGVPromocion.CurrentRow.Index].Cells[3].Value.ToString();

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            EPromocion prom = new EPromocion();
            prom.Idpromocion =int.Parse(TbId.Text);
            prom.Anio = TbAnio.Text;
            prom.Mes = CbMes.SelectedItem.ToString();
            prom.Idsoldado = int.Parse(TbIdSoldado.Text);
            IPromocion l_promocion = new LPromocion();
            l_promocion.ModificarPromocion(prom);
            ListarPromocion();
            DGVPromocion.ClearSelection();
            BtnModificar.Enabled = false;
        }
    }
}

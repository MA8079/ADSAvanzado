using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAServicios_TSMV.CapaEntidades;
using SAServicios_TSMV.CapaInterfaces;
using SAServicios_TSMV.CapaLogica;


namespace SAServicios_TSMV.CapaPresentacion
{
    public partial class FormAscenso : Form
    {
        
        public FormAscenso()
        {
            InitializeComponent();
            CargarGrado();
            ListarAscensos();
            
        }
    
        private void ListarAscensos()
        {
            /*foreach (DataGridViewColumn Col in DGVAscensos.Columns)
            {
                Col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }*/
            IAscenso lAscenso = new LAscenso();
            DataTable table = lAscenso.CargarAscenso();
            DGVAscensos.DataSource = table;
        }


        private void CargarGrado()
        {
            String[] grados = { "Cabo", "Sargento 2°", "Sargento 1°" };
            for (int i = 0; i < grados.Length; i++)
            {
                CbGrado.Items.Add(grados[i]);
            }
        }

        #region Programación de Botones
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            EAscenso OAscenso = new EAscenso();
            OAscenso.Fecha = DTfecha.Value.ToString("yyyy-MM-dd");
            OAscenso.Grado = CbGrado.SelectedItem.ToString();
            OAscenso.Idsoldado = int.Parse(CbSoldado.SelectedValue.ToString());
            IAscenso LogAscenso = new LAscenso();
            LogAscenso.RegistrarAscenso(OAscenso);
            ListarAscensos();
            BtnGuardar.Enabled = false;
            DGVAscensos.Enabled = true;
            BtnNuevo.Enabled = true;
        }
        //private void BtnActualizar_Click(object sender, EventArgs e)
        //{
            
        //    EAscenso OAscenso = new EAscenso();
        //    OAscenso.Idascenso = int.Parse(TbId.Text);
        //    OAscenso.Fecha = DTfecha.Value.ToString("yyyy-MM-dd");
        //    OAscenso.Grado = CbGrado.SelectedItem.ToString();
        //    OAscenso.Idsoldado = int.Parse(CbSoldado.SelectedValue.ToString());
        //    IAscenso LogAscenso = new LAscenso();
        //    LogAscenso.ModificarAscenso(OAscenso);
        //    ListarAscensos();
        //}
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            //EN OBSERVACIÓN
            DGVAscensos.ClearSelection();
            TbId.Text = "";
            DTfecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
            DTfecha.Enabled = true;
            CbGrado.Enabled = true;
            CbSoldado.Enabled = true;
            BtnGuardar.Enabled = true;            
            DGVAscensos.Enabled = false;
            BtnNuevo.Enabled = false;
            BtnEliminar.Enabled = false;
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            EAscenso OAscenso = new EAscenso();
            OAscenso.Idascenso = int.Parse(TbId.Text);
            IAscenso LogAscenso = new LAscenso();
            LogAscenso.EliminarAscenso(OAscenso);
            ListarAscensos();
        }

        #endregion

        //private void Indicador_Click(object sender, EventArgs e)
        //{
        //    DGVAscensos.ClearSelection();
        //    TbId.Text = "";
        //    DTfecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
        //    DTfecha.Enabled = true;
        //    CbGrado.Enabled = true;
        //    CbSoldado.Enabled = true;
        //    BtnGuardar.Enabled = true;
        //    Indicador.Visible = false;
        //    DGVAscensos.Enabled = false;
        //    BtnNuevo.Enabled = false;
        //    BtnEliminar.Enabled = false;

        //}

        private void CbGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            String Grado;
            ISoldado soldado = new LSoldado();
            if (CbGrado.SelectedItem.ToString() == "Cabo")
            {
                Grado = "Soldado";
                soldado.ListarPorGrado(CbSoldado, Grado);

            }
            if (CbGrado.SelectedItem.ToString() == "Sargento 2°")
            {
                Grado = "Cabo";
                soldado.ListarPorGrado(CbSoldado, Grado);

            }
            if (CbGrado.SelectedItem.ToString() == "Sargento 1°")
            {
                Grado = "Sargento 2°";
                soldado.ListarPorGrado(CbSoldado, Grado);

            }


        }

        private void DGVAscensos_MouseCaptureChanged(object sender, EventArgs e)
        {
            BtnEliminar.Enabled = true;
            //BtnNuevo.Enabled = true;
            BtnActualizar.Enabled = false; ;
            TbId.Text = DGVAscensos.Rows[DGVAscensos.CurrentRow.Index].Cells[0].Value.ToString();
        }
        //private void CargarFormulario()
        //{
            
        //    DTfecha.Value = Convert.ToDateTime(DGVAscensos.Rows[DGVAscensos.CurrentRow.Index].Cells[1].Value.ToString());
        //    CbGrado.Text = DGVAscensos.Rows[DGVAscensos.CurrentRow.Index].Cells[2].Value.ToString();//**Observar            
        //    CbSoldado.SelectedValue = DGVAscensos.Rows[DGVAscensos.CurrentRow.Index].Cells[3].Value.ToString();//**Observar
        //}

    }
}

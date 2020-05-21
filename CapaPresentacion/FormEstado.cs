using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAServicios_TSMV.CapaEntidades;
using SAServicios_TSMV.CapaInterfaces;
using SAServicios_TSMV.CapaLogica;
using SAServicios_TSMV.CapaPresentacion;
namespace SAServicios_TSMV.CapaPresentacion
{
    public partial class FormEstado : Form
    {
        static int RED = 0;
        static int REO = 0;
        static string Var_Apellido = null;
        String Estado, Motivo;
        public FormEstado()
        {
            InitializeComponent();
            LblFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
            CargarSoldado();
            ListarEstado();

        }

        private void ListarEstado()
        {
            EEstado estado = new EEstado();
            estado.Fecha = LblFecha.Text;
            IEstado l_estado = new LEstado();
            DataTable Tabla = l_estado.ListarEstado(estado);
            DGVEstado.DataSource = Tabla;
        }

        private void CargarSoldado()
        {
            ISoldado soldado = new LSoldado();
            DataTable Tabla = soldado.ListarSoldado();
            LBsoldados.DataSource = Tabla;
            LBsoldados.DisplayMember = "Apellido";
            LBsoldados.ValueMember = "ID";
            LBsoldados.ClearSelected();
            LBsoldados.Enabled = false;
        }

        private void RegistrarEstado(String estado, String motivo)
        {
            EEstado Oestado = new EEstado();
            Oestado.Estado = estado;
            Oestado.Motivo = motivo;
            Oestado.Fecha = LblFecha.Text;
            Oestado.Idsoldado = int.Parse(LBsoldados.SelectedValue.ToString());
            IEstado LEstado = new LEstado();
            LEstado.RegistrarEstado(Oestado);
            ListarEstado();
        }

        #region Funciones Panel Tabla 2,ListBox,Registro de Estado

        private void BtnDisponible_Click(object sender, EventArgs e)
        {
            LBsoldados.Enabled = true;
            MessageBox.Show("Selecciona un Soldado de la lista");
            RED = 1;
            if (RED == 1 && REO == 0)
            {
                BtnDisponible.Visible = false;
                BtnCancelarDisponible.Visible = true;
                BtnOtro.Enabled = false;
            }
        }
        private void BtnOtro_Click(object sender, EventArgs e)
        {
            TbMotivo.Enabled = true;
            LBsoldados.Enabled = true;
           // TbEstado.Enabled = true;

            MessageBox.Show("Selecciona un Soldado de la lista");
            REO = 1;
            if (RED == 0 && REO == 1)
            {
                BtnOtro.Visible = false;
                BtnCancelarOtro.Visible = true;
                BtnDisponible.Enabled = false;
            }
           
            
        }
        private void BtnCancelarDisponible_Click(object sender, EventArgs e)
        {
            RED = 0;
            BtnCancelarDisponible.Visible = false;
            BtnDisponible.Visible = true;
            BtnOtro.Enabled = true;
            LBsoldados.Enabled = false;
        }
        private void BtnCancelarOtro_Click(object sender, EventArgs e)
        {
            REO = 0;
            BtnCancelarOtro.Visible = false;
            BtnOtro.Visible = true;
            BtnDisponible.Enabled = true;
            LBsoldados.Enabled = false;
        }
        #endregion

        #region Funciones DGV Estado,Boton Eliminar Modificar
        private void DGVEstado_MouseCaptureChanged(object sender, EventArgs e)
        {

            TbEstado.Enabled = true;
            TbMotivo.Enabled = true;
            BtnModificar.Enabled = true;
            TbId.Enabled = true;
            TbId.Text = DGVEstado.Rows[DGVEstado.CurrentRow.Index].Cells[0].Value.ToString();
            Var_Apellido = DGVEstado.Rows[DGVEstado.CurrentRow.Index].Cells[1].Value.ToString();//Variable declarada a nivel de clase.
            TbEstado.Text = DGVEstado.Rows[DGVEstado.CurrentRow.Index].Cells[2].Value.ToString();
            TbMotivo.Text = DGVEstado.Rows[DGVEstado.CurrentRow.Index].Cells[3].Value.ToString();

        }
        private void BtnModificar_Click(object sender, EventArgs e)
        {

            EEstado estado = new EEstado();
            estado.Idestado = int.Parse(TbId.Text);
            estado.Estado = TbEstado.Text;
            estado.Motivo = TbMotivo.Text;
            estado.Fecha = LblFecha.Text;
            estado.Idsoldado = IdSoldado(Var_Apellido);
            IEstado L_estado = new LEstado();
            L_estado.ModificarEstado(estado);
            ListarEstado();
        }
        private int IdSoldado(String apellido)
        {
            ISoldado l_soldado = new LSoldado();
            int IdSoldado = l_soldado.ObtenerID(apellido);
            return IdSoldado;
        }



        #endregion



        //Registrar soldado al seleccionar un item de la lista.
        private void LBsoldados_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (RED == 1)
            {
                Estado = "Disponible";
                Motivo = "S/N";
                RegistrarEstado(Estado, Motivo);
                label4.Text = "Ultimo Registrado :" + LBsoldados.Text;
                LBsoldados.ClearSelected();
            }
            if (REO == 1)
            {

                if (TbMotivo.Text != "")
                {
                    Estado = "No Disponible";
                    Motivo = TbMotivo.Text;
                    RegistrarEstado(Estado, Motivo);
                    label4.Text = "Ultimo Registrado :" + LBsoldados.Text;
                    LBsoldados.ClearSelected();
                    TbMotivo.Clear();
                    
                }
                else
                {
                    MessageBox.Show("Llena el campo Motivo y vuelve a seleccionar");
                    TbMotivo.Focus();
                }

               
            }
        }
    }
}

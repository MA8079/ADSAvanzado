using SAServicios_TSMV.CapaComun.Cache;
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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
            CustomizedDesign();
            CargarDatosUsuario();
        }
        private void CargarDatosUsuario()
        {
            LabelUsuario.Text = CacheUserLogin.Nombre;
            LabelTipo.Text = CacheUserLogin.Tipo;
        }
        private void CustomizedDesign()
        {
            SubmenuServicios.Visible = false;
            SubmenuPersonal.Visible = false;            
        }
        private void OcultarSubmenu()
        {
            if (SubmenuServicios.Visible==true)
            {
                SubmenuServicios.Visible = false;
            }
            if (SubmenuPersonal.Visible==true)
            {
                SubmenuPersonal.Visible = false;
            }
        }
        private void MostrarSubmenu(Panel submenu)
        {
            if (submenu.Visible==false)
            {
                OcultarSubmenu();
                submenu.Visible=true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        #region Submenu Servicios
        private void BtnServicio_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(SubmenuServicios);
        }

        private void BtnAgregarServicio_Click(object sender, EventArgs e)
        {
            //Pueba de boton
            AbrirFormulario(new FormServicio());
            OcultarSubmenu();
        }

        private void BtnServDiario_Click(object sender, EventArgs e)
        {
            //Pueba de boton
            AbrirFormulario(new FormServicioDiario());
            OcultarSubmenu();
        }

        private void BtnServSemanal_Click(object sender, EventArgs e)
        {
            //Pueba de boton
            AbrirFormulario(new FormServicioSemana());
            OcultarSubmenu();
        }
        #endregion
        #region Submenu de personal militar

        private void BtnPersonal_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(SubmenuPersonal);
        }

        private void BtnSoldado_Click(object sender, EventArgs e)
        {
            //Prueba de boton
            AbrirFormulario(new FormSoldado());
            OcultarSubmenu();
        }

        private void BtnPromocion_Click(object sender, EventArgs e)
        {
            //Prueba de boton
            AbrirFormulario(new FormPromocion());
            OcultarSubmenu();
        }

        private void BtnAscenso_Click(object sender, EventArgs e)
        {
            ////Prueba de boton
            AbrirFormulario(new FormAscenso());
            OcultarSubmenu();
        }

        private void BtnEstado_Click(object sender, EventArgs e)
        {
            //Prueba de boton
            AbrirFormulario(new FormEstado());
            OcultarSubmenu();
        }
        #endregion
        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            //Codigo
            AbrirFormulario(new FormUsuario());
            
        }
        private Form FormActivo = null;
        private void AbrirFormulario(Form OForm)
        {
            
            if (FormActivo!=null)
            {
                
                FormActivo.Close();                
            }
            FormActivo = OForm;
            OForm.TopLevel = false;
            OForm.FormBorderStyle = FormBorderStyle.None;
            OForm.Dock = DockStyle.Fill;
            PanelContenedor.Controls.Add(OForm);
            PanelContenedor.Tag = OForm; //Asociar el formulario con el panel contenedor
            OForm.BringToFront();
            OForm.Show();
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La sesión finalizará");
            this.Close();
        }

        private void BtnSalirSistema_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

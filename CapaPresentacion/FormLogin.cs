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
using SAServicios_TSMV.CapaPresentacion;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace SAServicios_TSMV.CapaPresentacion
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TbUsuario.Text!="USUARIO")
            {
                
                if (TbPass.Text!="CONTRASEÑA")
                {
                    EUsuario Usuario = new EUsuario();
                    Usuario.Nombreusuario = TbUsuario.Text;
                    Usuario.Contrasenia = TbPass.Text;
                    IUsuario User = new LUsuario();
                    DataTable Tabla = User.ValidarLogin(Usuario);
                    if (Tabla.Rows.Count == 1)
                    {
                        FormInicio Inicio = new FormInicio();
                        Inicio.Show();
                        Inicio.FormClosed += CerrarSesión;
                        this.Hide();
                    }
                    else
                    {
                        Error("Usuario y/o Contraseña Inválidos");                        
                        TbPass.Text = "CONTRASEÑA";
                        TbPass.UseSystemPasswordChar = false;
                        TbUsuario.Focus();
                    }
                }
                else
                {
                    Error("Ingresar Contraseña");
                    TbPass.Focus();
                }
            }
            else
            {
                Error("Ingresar Usuario");               
            }         
        }
        private void CerrarSesión(object sender, FormClosedEventArgs e)
        {
            TbUsuario.Clear();
            TbPass.Clear();
            TbUsuario.Text = "USUARIO";
            TbPass.Text = "CONTRASEÑA";
            TbPass.UseSystemPasswordChar = false;
            LabelError.Visible = false;
            this.Show();
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Error(string msg)
        {
            LabelError.Text = "! " + msg;
            LabelError.Visible = true;
        }

        #region COMPORTAMIENTO DE TEXTBOX
        private void TbUsario_Enter(object sender, EventArgs e)
        {
            if (TbUsuario.Text=="USUARIO")
            {
                TbUsuario.Text = "";
                LabelError.Visible = false;
                TbUsuario.ForeColor = Color.LightSeaGreen;
            }
        }

        private void TbPass_Enter(object sender, EventArgs e)
        {
            if (TbPass.Text=="CONTRASEÑA")
            {
                TbPass.Text = "";
                
                TbPass.ForeColor = Color.LightSeaGreen;
                TbPass.UseSystemPasswordChar = true;
            }
        }

        private void TbUsuario_Leave(object sender, EventArgs e)
        {
            if (TbUsuario.Text == "")
            {
                TbUsuario.Text = "USUARIO";
                TbUsuario.ForeColor = Color.Turquoise;
            }
        }

        private void TbPass_Leave(object sender, EventArgs e)
        {
            if (TbPass.Text == "")
            {
                TbPass.Text = "CONTRASEÑA";
                TbPass.ForeColor = Color.Turquoise;
                TbPass.UseSystemPasswordChar = false;
            }
        }
        #endregion
                
        #region MOVER FORMULARIO
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
                
    }
}


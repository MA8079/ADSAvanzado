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
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
            ListarUsuarios();

        }

        private void ListarUsuarios()
        {
            IUsuario usuario = new LUsuario();
            DgvUsuario.DataSource = usuario.ListarUsuarios();
            DgvUsuario.ClearSelection();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            EUsuario usuario = new EUsuario();
            usuario.Nombreusuario = tbuser.Text;
            usuario.Contrasenia = tbpass.Text;
            usuario.Tipo = tbtipo.Text;
            IUsuario lusuario = new LUsuario();
            lusuario.RegistrarUsuario(usuario);
            limpiar();
            ListarUsuarios();
        }
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            EUsuario usuario = new EUsuario();
            usuario.Idusuario = int.Parse(tbid.Text);
            usuario.Nombreusuario = tbuser.Text;
            usuario.Contrasenia = tbpass.Text;
            usuario.Tipo = tbtipo.Text;
            IUsuario lusuario = new LUsuario();
            lusuario.RegistrarUsuario(usuario);
            limpiar();
            ListarUsuarios();
            btneliminar.Enabled = false;
            btnmodificar.Enabled = false;
        }

        private void limpiar()
        {
            tbid.Clear();
            tbuser.Clear();
            tbpass.Clear();
            tbtipo.Clear();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            EUsuario usuario = new EUsuario();
            usuario.Idusuario = int.Parse(tbid.Text);
            IUsuario lusuario = new LUsuario();
            lusuario.EliminarUsuario(usuario);
            limpiar();
            ListarUsuarios();
            btneliminar.Enabled = false;
            btnmodificar.Enabled = false;
        }

        private void DgvUsuario_MouseCaptureChanged(object sender, EventArgs e)
        {
            btneliminar.Enabled = true;
            btnmodificar.Enabled = true;
            tbid.Text = DgvUsuario.Rows[DgvUsuario.CurrentRow.Index].Cells[0].Value.ToString();
            tbuser.Text= DgvUsuario.Rows[DgvUsuario.CurrentRow.Index].Cells[1].Value.ToString();
            tbpass.Text= DgvUsuario.Rows[DgvUsuario.CurrentRow.Index].Cells[2].Value.ToString();
            tbtipo.Text= DgvUsuario.Rows[DgvUsuario.CurrentRow.Index].Cells[3].Value.ToString();
        }

        private void Btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
            DgvUsuario.ClearSelection();
            btneliminar.Enabled = false;
            btnmodificar.Enabled = false;
        }
    }
}

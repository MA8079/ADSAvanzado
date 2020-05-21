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
    public partial class FormSoldado : Form
    {
        static int ID = 0;
        public FormSoldado()
        {
            InitializeComponent();
            ListarSoldado();
        }

        private void ListarSoldado()
        {
            ISoldado l_soldado = new LSoldado();
            DataTable Tabla = l_soldado.ListarSoldado();
            DGVSoldado.DataSource = Tabla;
        }

        private void DGVSoldado_MouseCaptureChanged(object sender, EventArgs e)
        {
            BtnEliminar.Enabled = true;
            BtnModificar.Enabled = true;
            TbId.Text = DGVSoldado.Rows[DGVSoldado.CurrentRow.Index].Cells[0].Value.ToString();
            TbNombre.Text = DGVSoldado.Rows[DGVSoldado.CurrentRow.Index].Cells[1].Value.ToString();
            TbApellido.Text = DGVSoldado.Rows[DGVSoldado.CurrentRow.Index].Cells[2].Value.ToString();
            TbDni.Text = DGVSoldado.Rows[DGVSoldado.CurrentRow.Index].Cells[3].Value.ToString();
            TbPlaca.Text = DGVSoldado.Rows[DGVSoldado.CurrentRow.Index].Cells[4].Value.ToString();
            DTFecha.Value =Convert.ToDateTime(DGVSoldado.Rows[DGVSoldado.CurrentRow.Index].Cells[5].Value.ToString());

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TbId.Clear();
            TbNombre.Clear();
            TbApellido.Clear();
            TbDni.Clear();
            TbPlaca.Clear();
            DGVSoldado.ClearSelection();
            BtnEliminar.Enabled = false;
            BtnModificar.Enabled = false;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ESoldado soldado = new ESoldado();
            soldado.Idsoldado = int.Parse(TbId.Text);
            soldado.Nombre = TbNombre.Text;
            soldado.Apellido = TbApellido.Text;
            soldado.Dni = TbDni.Text;
            soldado.Numeroplaca = TbPlaca.Text;
            soldado.Fecha = DTFecha.Value;
            ISoldado l_soldado = new LSoldado();
            l_soldado.EliminarSoldado(soldado);
            ListarSoldado();

        }

        private void TbDni_Leave(object sender, EventArgs e)
        {
            if (TbDni.TextLength==8)
            {
                TbPlaca.Text = "00" + TbDni.Text;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ESoldado soldado = new ESoldado();
            soldado.Nombre = TbNombre.Text;
            soldado.Apellido = TbApellido.Text;
            soldado.Dni = TbDni.Text;
            soldado.Numeroplaca = TbPlaca.Text;
            soldado.Fecha = DTFecha.Value;            
            ISoldado l_soldado = new LSoldado();
            l_soldado.RegistrarSoldado(soldado);
            RegistrarAscenso();
            RegistrarPromocion();
            ListarSoldado();
            MessageBox.Show("Registro Completado");
        }
        private int RecuperarID(String Apellido)
        {
            ISoldado soldado = new LSoldado();
            int ID=soldado.ObtenerID(Apellido);
            return ID;
        }
        private void RegistrarAscenso()
        {
            EAscenso ascenso = new EAscenso();
            ascenso.Fecha = DTFecha.Value.ToString("yyyy-MM-dd");            
            ascenso.Grado = "Soldado";
            ID= RecuperarID(TbApellido.Text);
            ascenso.Idsoldado = ID; 
            IAscenso l_ascenso = new LAscenso();
            l_ascenso.RegistrarAscenso(ascenso);
        }
        private void RegistrarPromocion()
        {
            EPromocion promocion = new EPromocion();
            promocion.Anio = DateTime.Now.ToString("yyyy");
            promocion.Mes = AsignarMes(DTFecha);
            if (ID!=0)
            {
                promocion.Idsoldado = ID;
                IPromocion l_promocion = new LPromocion();
                l_promocion.RegistrarPromocion(promocion);
                ID = 0;
            }
            else
            {
                MessageBox.Show("Error de ID Soldado");
            }

        }
        private String AsignarMes(DateTimePicker picker)
        {
            int[] grupo1 = { 01, 02, 03, 04, 05, 06 };
            String Fecha = picker.Value.ToString("dd-MM-yyyy");
            String[] cadena = Fecha.Split('-');

            int elemento = int.Parse(cadena[1]);
            int i = 0;
            bool estado = false;
            while (estado==false&&i<grupo1.Length)
            {
                if (elemento==grupo1[i])
                {
                    estado = true;
                }
                i++;
            }
            if (estado==true)
            {
                return "Enero";
            }
            else
            {
                return "Julio";
            }

            
        }
    }
}

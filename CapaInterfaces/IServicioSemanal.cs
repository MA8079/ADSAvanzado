using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAServicios_TSMV.CapaEntidades;

namespace SAServicios_TSMV.CapaInterfaces
{
    interface IServicioSemanal
    {
        DataTable ListarServicioSemanal();
        void ListarServicioSemanal(ComboBox combo);
        void EliminarServicio(EServicioSemana eServicioSemana);
        void ModificarServicio(EServicioSemana eServicioSemana);
        void RegistrarServicio(EServicioSemana eServicioSemana);
    }
}

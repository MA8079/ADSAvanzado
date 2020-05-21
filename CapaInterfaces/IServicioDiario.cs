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
    interface IServicioDiario
    {
        DataTable ListarServicioDiario();
        void ListarServicioDiario(ComboBox combo);
        void RegistrarServicioDiario(EServicioDiario eServicioDiario);
        void ModificarServicioDiario(EServicioDiario eServicioDiario);
        void EliminarServicioDiario(EServicioDiario eServicioDiario);
    }
}

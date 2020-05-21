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
    interface IServicio
    {
        DataTable ListarServicio();
        
        void ListarServicio(ComboBox combo);
        void RegistrarServicio(EServicio eServicio);
        void ModificarServicio(EServicio eServicio);
        void EliminarServicio(EServicio eServicio);
    }
}

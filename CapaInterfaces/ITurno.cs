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
    interface ITurno
    {
        DataTable ListarTurno();
        void ListarTurno(ComboBox combo);
        void EliminarTurno(ETurno eTurno);
        void RegistrarTurno(ETurno eTurno);
        void ModificarTurno(ETurno eTurno);
        
    }
}

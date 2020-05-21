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
    interface ISoldado
    {
        DataTable ListarSoldado();
        void ListarSoldado(CheckedListBox checkedList);
        int ObtenerID(String condicion);

        void ListarSoldado(ComboBox combo);
        void ListarPorGrado(ComboBox combo,String Grado);
        void SoldadoDisponible(ComboBox combo);
        void EliminarSoldado(ESoldado eSoldado);
        void ModificarSoldado(ESoldado eSoldado);
        void RegistrarSoldado(ESoldado eSoldado);
        DataTable SoldadoDisponible();
        
    }
}

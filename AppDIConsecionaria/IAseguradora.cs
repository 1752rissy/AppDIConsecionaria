using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDIConsecionaria
{
    public interface  IAseguradora
    {
        string TramitarAltaAseguradora(Vehiculo vehiculo);
        string MostrarPoliza(Vehiculo vehiculo);
    }
}

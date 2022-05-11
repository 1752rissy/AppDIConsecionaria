using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDIConsecionaria
{
    public interface IAseguradoraCalculo
    {
        double CalcularAumentoPoliza(Vehiculo vehiculo);

        double CalcularDescuentoPoliza(Vehiculo vehiculo);
    }
}

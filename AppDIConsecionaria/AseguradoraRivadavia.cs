using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDIConsecionaria
{
    public class AseguradoraRivadavia : IAseguradora, IAseguradoraCalculo
    {
        public string NombreAseguradora { get; set; }

        public double CalcularAumentoPoliza(Vehiculo vehiculo)
        {
            double aumento = vehiculo.Precio + vehiculo.Precio * 0.15;
            return aumento;
        }

        public double CalcularDescuentoPoliza(Vehiculo vehiculo)
        {
            throw new NotImplementedException();
        }

        public string MostrarPoliza(Vehiculo vehiculo)
        {
            throw new NotImplementedException();
        }

        public string TramitarAltaAseguradora(Vehiculo vehiculo)
        {
            throw new NotImplementedException();
        }
    }
}

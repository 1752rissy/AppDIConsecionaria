using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDIConsecionaria
{
    public class AseguradoraTR : IAseguradora, IAseguradoraCalculo
    {
        public string NombreAseguradora { get; set; }

        public double CalcularAumentoPoliza(Vehiculo vehiculo)
        {
            double aumento = vehiculo.Precio + vehiculo.Precio * 0.25;
            return aumento; 
        }

        public double CalcularDescuentoPoliza(Vehiculo vehiculo)
        {
            throw new NotImplementedException();
        }

        public string MostrarPoliza(Vehiculo vehiculo)
        {
            return "poliza para "+ NombreAseguradora + vehiculo.Poliza + " del vehiculo con patente : " + vehiculo.Patente;
        }

        public string TramitarAltaAseguradora(Vehiculo vehiculo)
        {
            return "seguro TRIUNFO dado de alta para el vehiculo : " + vehiculo.Patente;
        }
    }
}

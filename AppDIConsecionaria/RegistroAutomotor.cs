using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDIConsecionaria
{
    public class RegistroAutomotor
    {
        public string NombreRegistro { get; set; }

        public string GenerarPatentamientoVehiculo(Vehiculo vehiculo)
        {
           return "vehiculo de patente " + vehiculo.Patente + " patentamiento generado";
        }


    }
}

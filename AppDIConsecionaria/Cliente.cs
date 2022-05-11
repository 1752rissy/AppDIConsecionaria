using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDIConsecionaria
{
    public class Cliente
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }  
        public string Apellido { get; set; }
        public List<Vehiculo> Vehiculos { get; set; }

        //agregacion
        public void ComprarVehiculo(Vehiculo vehiculo)
        {
            Vehiculos.Add(vehiculo);    
        }

    }
}

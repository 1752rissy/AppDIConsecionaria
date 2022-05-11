using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDIConsecionaria
{
    public  class Consecionaria 
    {
        public string Nombre { get; set; }

        public List<Vehiculo> vehiculos { get; set; }

        //composicion uno a varios 
        public Consecionaria()
        {
            vehiculos = new List<Vehiculo>();   
        }

        public void AgregarVehiculos(Vehiculo vehiculo)
        {
            vehiculos.Add(vehiculo);
        }

        //inyeccion de dependencia por metodo 
        public void AsegurarVehiculo(IAseguradora aseguradora, Vehiculo vehiculo)
        {
            aseguradora.TramitarAltaAseguradora(vehiculo);
        }

        public string RegistrarVehiculo(RegistroAutomotor registro, Vehiculo vehiculo)
        {
           return registro.GenerarPatentamientoVehiculo(vehiculo);
        }


    }
}

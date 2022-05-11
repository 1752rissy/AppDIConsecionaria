using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDIConsecionaria
{
    public class AseguradoraSC : IAseguradora
    {
        public string NombreAseguradora { get; set; }

        public string MostrarPoliza(Vehiculo vehiculo)
        {
            if(vehiculo.Marca == "Ford")
            return "poliza para  :"+ NombreAseguradora + vehiculo.Poliza+ " del vehiculo con patente : "+ vehiculo.Patente+ "marca : "+vehiculo.Marca;
            else
                return "poliza para San Cristobal " + vehiculo.Poliza + " del vehiculo con patente : " + vehiculo.Patente;
        }

        public string TramitarAltaAseguradora(Vehiculo vehiculo)
        {
            return "seguro san cristobal dado de alta para el vehiculo : " + vehiculo.Patente;
        }
    }
}

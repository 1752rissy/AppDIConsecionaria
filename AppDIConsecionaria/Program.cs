using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDIConsecionaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Consecionaria consecionaria = new Consecionaria();
            Vehiculo FiatCronos = new Vehiculo();
            consecionaria.AgregarVehiculos(FiatCronos); ;

            RegistroAutomotor registro = new RegistroAutomotor();
            Console.WriteLine( consecionaria.RegistrarVehiculo(registro, FiatCronos));


            AseguradoraTR aseguradoraTR = new AseguradoraTR();
            Console.WriteLine("el aumento para triunfo es de :" + aseguradoraTR.CalcularAumentoPoliza(FiatCronos));




            AseguradoraSC aseguradoraSancor= new AseguradoraSC();
            AseguradoraRivadavia aseguradoraRivadavia = new AseguradoraRivadavia();
            Vehiculo FiatArgo = new Vehiculo();
            consecionaria.AgregarVehiculos(FiatArgo);

            foreach(Vehiculo vehiculo in consecionaria.vehiculos)
            {
                if(vehiculo.Marca == "Fiat")
                {
                    consecionaria.AsegurarVehiculo(aseguradoraSancor, vehiculo);
                }
                if(vehiculo.Marca == "Chevrolet")
                {
                    consecionaria.AsegurarVehiculo(aseguradoraTR, vehiculo);
                }
                if (vehiculo.Marca == "Ford")
                {
                    consecionaria.AsegurarVehiculo(aseguradoraRivadavia, vehiculo);
                }
            }


            List<IAseguradoraCalculo> aseguradorasCalculos = new List<IAseguradoraCalculo>();
            aseguradorasCalculos.Add(aseguradoraTR);
            aseguradorasCalculos.Add(aseguradoraRivadavia);

            //open close
            foreach(IAseguradoraCalculo calculoAseguradora in aseguradorasCalculos )
            {
                calculoAseguradora.CalcularAumentoPoliza(FiatArgo);
            }



            Console.ReadLine();


        }
    }
}

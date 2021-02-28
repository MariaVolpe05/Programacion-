using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {

            string cadena = "";
            double altura = 0.0;
            int edad = 0;


            Console.WriteLine("Hola buenas tardes, a continuacion en la consola le pediremos que ingrese algunos datos para permitir su ingreso a Skate-park");
            Console.WriteLine("");
            Console.WriteLine("Ingrese su edad");
            cadena = Console.ReadLine();
            edad = Convert.ToInt32 (cadena);



            if (edad<=18)
                {
                    Console.WriteLine("disculpe no llega a la edad requerida para el ingreso")
                }
           
                else
                {
                    Console.WriteLine("Buen dia, sea bienvenid@ al skate-park");
            
                    Console.WriteLine("ingrese su estatura a continuación:");
                    cadena = Console.ReadLine();
                    edad = Convert.ToInt32(cadena);

                }

            if (altura < 1.5);
                {
                    Console.WriteLine("Perfecto, usted tiene acceso a las 5 rampas. Disfrute del Skate-park !");
                }

                else
                {
                    Console.WriteLine("Bien, usted tiene acceso a 3 de 5 rampas. Disfrute del Skate-park!");
                }

            }

        Console.ReadKey();
        }
    }






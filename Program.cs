using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="Recreando porcentaje ganado";
            Double total, contestadas, proceso;

            Console.Write("\n Ingrese la cantidad total de respuestas: ");
            total = Double.Parse(Console.ReadLine());
            Console.Write("\n Ingrese la cantidad  de respuestas contestadas correctamente: ");
            contestadas = Double.Parse(Console.ReadLine());

            proceso = (contestadas * 100) / total;
            if (proceso >= 90)
            {
                Console.WriteLine("Tienes un nivel maximo con " + contestadas + " respuestas correctas");

            }else if (proceso >= 75 && proceso < 90)
            {
                Console.WriteLine("Tienes un nivel medio con " + contestadas + " respuestas correctas ");
            }
            if (proceso >= 50 && proceso < 75)
            {
                Console.Write("Tienes un nivel regular con "+ contestadas + " respuestas correctas ");
            }
            else if (proceso < 50)
            {
                Console.Write("Lo siento tu nivel esta fuera de rango con "+ contestadas + " respuestas correctas");
            }

            Console.WriteLine("\n Gracias por participar vuelve pronto!!");
            Console.ReadKey();
           

        }
    }
}

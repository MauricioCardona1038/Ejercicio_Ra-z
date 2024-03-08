using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria_bella_Napoli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar pizza vegetariana

            Console.WriteLine("Bienvenido a la pizzeria Bella Napoli");
            Console.WriteLine("¿ Desea una pizza vegetariana? (Si/No): ");
            string tipoPizza = Console.ReadLine().ToLower();
            string ingredienteElegido = "";

            if (tipoPizza == "si" || tipoPizza == "si")
            {
                Console.WriteLine("Ingredientes vegetarianos disponibles:");
                Console.WriteLine("1. Pimiento");
                Console.WriteLine("2. Tofu");
                Console.WriteLine("Seleccione el ingrediente que desea agregar (1 0 2): ");
                string eleccion = Console.ReadLine();
                if (eleccion == "1")
                {
                    ingredienteElegido = "Pimiento";
                }
                else if (eleccion == "2") 
                {
                    ingredienteElegido = "Tofu";
                }
                else 
                {
                    Console.WriteLine("Opción no válida, no se agregará ingrediente adicional.");
                }
                Console.WriteLine($"Usted ha elegido una pizza vegetariana con los siguientes ingredientes: Mozzarella, Tomate, {ingredienteElegido}.");

            }
                else if (tipoPizza == "no")
                {
                  Console.WriteLine("Ingredientes no vegetarianos disponibles:");
                  Console.WriteLine("1. Peperoni");
                  Console.WriteLine("2. Jamón");
                  Console.WriteLine("3. Salmón");
                  Console.WriteLine("Seleccione el ingrediente que desea agregar (1, 2 o 3)");
                string eleccion = Console.ReadLine();
                  if (eleccion == "1") 
                    {
                    ingredienteElegido = "Peperoni";
                    }
                  else if(eleccion == "2") 
                    {
                    ingredienteElegido = "Jamón";
                    }
                  else if(eleccion =="3") 
                    {
                    ingredienteElegido = "Salmón";
                    }
                  else 
                    {
                    Console.WriteLine("Opción no válida, no se agregará ingrediente adicional.");
                    }
                Console.WriteLine($"Usted ha elegido una pizza no vegetariana con los siguintes ingredientes: Mozzarella, Tomate, {ingredienteElegido}.");
                }
            else 
             {
                Console.WriteLine("No ha seleccionado una opción válida.");
             }

        }
    }
}

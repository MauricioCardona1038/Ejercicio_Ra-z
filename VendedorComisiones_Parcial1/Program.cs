using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendedorComisiones_Parcial1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // declaracion de variables

            double sueldoBase,ventas1,ventas2,ventas3,comision,totalcomisiones,sueldoFinal;
            double mayorComision, promedioComisioines;
            double[]ventas = new double[3];
            const double PORCENTAJE_COMISION = 0.10;
            const double BENEFICIO_EXTRA = 100000;
            const double OBJETIVO_VENTAS = 1000000;


            // entrada de datos
            Console.WriteLine(" Inngrese sueldo base del vendedor$");
            sueldoBase = double.Parse(Console.ReadLine());

            for (int i = 0; i < ventas.Length; i++);
            {
                Console.WriteLine($"Ingrese el valor de la venta{ i+1}:$");
                    
            }

        }
    }
}

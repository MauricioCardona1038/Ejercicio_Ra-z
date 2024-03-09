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

            double sueldoBase,venta1,venta2,venta3,comision,totalcomisiones,sueldoFinal;
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
                Console.WriteLine($"Ingrese el valor de la venta{i+1}:$");
                ventas[i]=double.Parse(Console.ReadLine());
            }

            // Proceso
            venta1 = ventas[0];
            venta2 = ventas[1];
            venta3 = ventas[2];
            comision = (venta1 + venta2 + venta3) * PORCENTAJE_COMISION;
            totalcomisiones = comision;
            sueldoFinal = sueldoBase + totalcomisiones;
            mayorComision = Math.Max(Math.Max(venta1 * PORCENTAJE_COMISION, venta2 * PORCENTAJE_COMISION), venta3 * PORCENTAJE_COMISION);
            promedioComisioines = totalcomisiones / 3;

            // salida de resultados

            Console.WriteLine($"\nDinero obtenido por concepto de comisiones: $ {totalcomisiones}");
            Console.WriteLine($"\nTotal a recibir en el mes: $ {sueldoFinal}");
            Console.WriteLine($"\nLa venta que genero la mayor comision fue: $ {mayorComision}");
            Console.WriteLine($"\nEl promedio de las comisiones por venta fue: $ {promedioComisioines}");

            // Verificacion del beneficio extra
            if(venta1+venta2+venta3 >= OBJETIVO_VENTAS)
            {
                sueldoFinal += BENEFICIO_EXTRA;
                Console.WriteLine("Felicidades has ganado el beneficio extra de $ 100.000.");
                Console.WriteLine($"El sueldo final con el beneficio es:$"{sueldoFinal});
            }
        }
    }
}

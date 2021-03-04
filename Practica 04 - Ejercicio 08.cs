using System;
using System.Linq;

namespace Practica_04___Ejercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Porfavor introduzca las medidas:");
            double[] altura = new double[5];
            byte A;
            for (A = 0; A <= 4; A++)
            {
                altura[A] = Convert.ToDouble(Console.ReadLine());
            }
            double media = (altura.Sum()) / 5;
            Console.Clear();
            byte B;
            byte C = 0;
            byte D = 0;
            for (B = 0; B <= 4; B++)
            {
                if (altura[B] >= media)
                {
                    C++;
                }
                if (altura[B] < media)
                {
                    D++;
                }
            }
            Console.WriteLine("La media es: " + media);
            Console.WriteLine("Personas por encima de la media: " + C);
            Console.WriteLine("Personas por debajo de la media: " + D);
        }
    }
}

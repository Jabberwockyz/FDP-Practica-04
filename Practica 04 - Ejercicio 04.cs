using System;
using System.Linq;

namespace Practica_04___Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Porfavor introduzca 10 números:");
            int[] numero = new int[10];
            byte A;
            for (A = 0; A <= 9; A++)
            numero[A] = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("El mayor número introducido es: " + numero.Max());
        }
    }
}

using System;

namespace Practica_04___Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Porfavor introduzca 4 números:");
           int[] numeros = new int[4];
            numeros[0] = Convert.ToInt32(Console.ReadLine());
            numeros[1] = Convert.ToInt32(Console.ReadLine());
            numeros[2] = Convert.ToInt32(Console.ReadLine());
            numeros[3] = Convert.ToInt32(Console.ReadLine());
           int media = (numeros[0] + numeros[1] + numeros[2] + numeros[3]) / 4;
            Console.Clear();
            Console.WriteLine("Datos introducidos:");
            Console.WriteLine(numeros[0]);
            Console.WriteLine(numeros[1]);
            Console.WriteLine(numeros[2]);
            Console.WriteLine(numeros[3]);
            Console.WriteLine("La media aritmética es: " + media);
        }
    }
}

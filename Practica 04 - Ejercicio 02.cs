using System;

namespace Practica_04___Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Porfavor introduzca 5 números reales:");
            float[] numeros = new float[5];
            int C;
            for (C = 0; C <= 4; C++)
            numeros[C] = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            int P;
            for (P = 4; P >= 0; P--)
            Console.WriteLine(numeros[P]);
        }
    }
}

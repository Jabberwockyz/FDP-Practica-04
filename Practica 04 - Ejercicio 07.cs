using System;

namespace Practica_04___Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Porfavor escriba un nombre:");
            string nombre = Console.ReadLine();
            int L = nombre.Length;
            int A;
            L--;
            Console.Clear();
            for (A = 0; A <= L; A++)
            Console.Write(nombre[A] + " ");
        }
    }
}

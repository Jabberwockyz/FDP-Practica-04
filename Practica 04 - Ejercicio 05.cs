using System;

namespace Practica_04___Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombre = new string[100];
            int C;
            int P = 0;
            for (C = 0; C <= 99; C++)
            {
                P++;
                Console.WriteLine("Introduzca un nombre:");
                nombre[C] = Console.ReadLine();
                Console.Clear();
                bool Bool1 = nombre[C] == "";
                if (Bool1)
                {
                    Console.Clear();
                    Console.WriteLine("Nombres introducidos:");
                    int E;
                    P = P - 2;
                    for (E = 0; E <= P; E++)
                    {
                      Console.WriteLine(nombre[E]);
                    }
                    Console.ReadKey();
                    System.Environment.Exit(1);
                }
            }

        }
    }
}

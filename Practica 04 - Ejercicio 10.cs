using System;

namespace Practica_04___Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Porfavor introduzca el nombre:");
            string Nombre = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Porfavor introduzca la edad:");
            byte Edad = Convert.ToByte(Console.ReadLine());
            Console.Clear();
            if(Edad >= 18)
            {
                Console.WriteLine("Nombre: " + Nombre);
                Console.WriteLine("Edad: " + Edad);
                Console.WriteLine("Mayor de edad: Sí");
            }
            else
            {
                Console.WriteLine("Nombre: " + Nombre);
                Console.WriteLine("Edad: " + Edad);
                Console.WriteLine("Mayor de edad: No");
            }
        }
    }
}

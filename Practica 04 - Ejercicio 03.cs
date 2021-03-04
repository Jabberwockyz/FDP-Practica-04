using System;

namespace Practica_04___Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] Dias = {0,31,28,31,30,31,30,31,31,30,31,30,31};
            string[] Meses = {"nada","Enero","Febrero","Marzo","Abril","Mayo","Junio","Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre"};

            Console.WriteLine("Escriba el número del mes que desea seleccionar: \n1 - Enero  \n2 - Febrero \n3 - Marzo" +
                " \n4 - Abril \n5 - Mayo \n6 - Junio \n7 - Julio \n8 - Agosto \n9 - Septiembre \n10 - Octubre \n11 - Noviembre" +
                "\n12 - Diciembre");
            byte Selec = Convert.ToByte(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(Meses[Selec] + " tiene " + Dias[Selec] + " días.");
        }
    }
}

using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, resultado;

            Console.WriteLine("Piense en un numero");
            Console.ReadKey();
            Console.WriteLine("Multiplicar por 2");
            Console.ReadKey();
            Console.WriteLine("Sumele 8");
            Console.ReadKey();
            Console.WriteLine("Multiplicar por 5");
            Console.ReadKey();

            Console.Write("Ingrese el resultado: ");
            numero = Convert.ToInt32(Console.ReadLine());
            numero = numero / 10;
            resultado = numero - 4;

            Console.WriteLine("Su numero es: " + resultado);

            Console.ReadKey();


        }
    }
}

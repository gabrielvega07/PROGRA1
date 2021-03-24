using System;

namespace Area_de_Un_Circulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.1416, area, radio;
             

            Console.Write("Ingrese el radio del circulo:");
            radio = Convert.ToInt32(Console.ReadLine());

            area = pi * (radio 2);

            Console.WriteLine("el area es:" + area);
        }
    }
}

using System;

namespace Adivinar_fecha_de_cumple
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = 0, m = 0, resultado;
            int pos0, pos1, pos2, pos3;



            Console.WriteLine("Ingrese su dia de nacimiento");
            d = Convert.ToInt32(Console.ReadLine());
            d = ((d * 20) + 73) * 5;
            Console.WriteLine("Ingrese su mes de nacimiento: ");
            m = Convert.ToInt32(Console.ReadLine());
            resultado = d + m - 365;


            

            Console.WriteLine(resultado);
            Console.ReadKey();
            
            
            
            pos0 = (resultado % 10000) / 1000;
            pos1 = (resultado % 10000) % 1000 / 100;
            pos2 = ((resultado % 10000) % 1000) % 100 / 10;
            pos3 = (((resultado % 10000) % 1000) % 100) % 10;
            Console.WriteLine("Muy bien el dia de tu cumpleaños es: " + pos0 + pos1 + " y el  mes de tu cumpleaños es:" + pos2 + pos3);
            


        }
    }
}

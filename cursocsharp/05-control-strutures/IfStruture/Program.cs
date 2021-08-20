using System;

namespace IfStruture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número del 1 al 10");

            int nm1 = Convert.ToInt32(Console.ReadLine());


            if (nm1 < 10)
            {
                Console.WriteLine($"El número { nm1 }es mayor que 10");
            }

            if (nm1 > 10 || nm1 < 0)
            {
                Console.WriteLine($"{nm1} no es un número valido");
            }

            if (nm1 <= 10 && nm1 > 0)
            {
                Console.WriteLine($"Este {nm1} si esta en el rango");
            }

       

        }
    }
}

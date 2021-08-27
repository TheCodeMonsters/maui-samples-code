using System;

namespace IfStruture
{
    class Program
    {
        static void Main(string[] args)


        {

            #region IF
            // Console.WriteLine("Introduce un número del 1 al 10");

            // int nm1 = Convert.ToInt32(Console.ReadLine());

            // if (nm1 < 10)
            // {
            //     Console.WriteLine($"El número { nm1 }es mayor que 10");
            // }

            // if (nm1 > 10 || nm1 < 0)
            // {
            //     Console.WriteLine($"{nm1} no es un número valido");
            // }

            // if (nm1 <= 10 && nm1 > 0)
            // {
            //     Console.WriteLine($"Este {nm1} si esta en el rango");
            // }
            #endregion IF

            #region  ELSE


            // Console.WriteLine("Escibe tu nombre");
            // string name = Console.ReadLine();


            // if (name == "Carlos")
            // {
            //     Console.WriteLine("Te llamas Carlos");
            // }
            // else
            // {
            //     Console.WriteLine("Oye, tu no eres Carlos {0}", name);
            // }


            // Console.WriteLine("Números impares");
            // int numero = Convert.ToInt32(Console.ReadLine());

            // if (numero % 2 != 0)
            // {
            //     Console.WriteLine("Es un numero impar {0}", numero);
            // }
            // else
            // {
            //     Console.WriteLine("Este numerp es par {0}", numero);

            // }

            Console.WriteLine("Mayo y Menor de edad");
            int age = Convert.ToInt32(Console.ReadLine());
            int ruler = 18;
            
            if (age < ruler) {
                Console.WriteLine("Eres menor de edad, no tienes permiso para entrar {0}");
            }else{
                Console.WriteLine("Si, podes entrar sos mayor de edad");
            }

            #endregion ELSE


        }
    }
}

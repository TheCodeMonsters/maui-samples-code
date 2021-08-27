using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos un objeto coche
            // Coche c = new Coche(1, "BMW", "4", 100, 12000);

            // get de marca de coche
            // Console.WriteLine(c.marca);

            // get precio de coche
            // Console.WriteLine(c.precio);

            // Modifico el precio del coche con el set 
            // c.precio = 1500;

            // Vuelvo a mostrar para ver si se ha modificado
            // Console.WriteLine(c.precio);

            // Muestro el estado completo
            // Console.WriteLine(c.ToString());


            // Objetos de clase Rectangulo

            // Crear un objeto  de tipo rectagulo
            Rectangulo rect = new Rectangulo();
            rect.Base = 10;
            rect.Altura = 5;

            int area = rect.CalcularArea();
            Console.WriteLine("rect: {0} x {1}, area: {2}", rect.Base, rect.Altura, area);

            // Sintaxis de inicialización 
            Rectangulo rect2 = new Rectangulo { Base = 3, Altura = 8 };

            int area2 = rect2.CalcularArea();
            Console.WriteLine("rect2: {0} x {1}, area2: {2}", rect2.Base, rect2.Altura, area2);

            Console.ReadLine();


        }
    }
}

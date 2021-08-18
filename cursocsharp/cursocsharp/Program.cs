using System;

namespace cursocsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int a = 42;
            int b = 119;
            int c = a + b;
            // Console.WriteLine(c);
            // Console.ReadKey();
            #region variables
            string name = "Manuel";
            var lastName = " Duarte";
            short? edad = 20;
            Int16 altura = 178;
            float alturaEnMetros = 1.78f;

            Console.WriteLine("Hola " + name + lastName);

            Console.WriteLine("Mi nombre tiene " + name.Length + " letras");

            #endregion

            Console.WriteLine("Hola " + name + " " + lastName);

            Console.WriteLine(string.Format("Mi nombre tiene {0} letras", name.Length));

            // con .Trim() eliminamos los espacios en blancos del string
            Console.WriteLine($"Mi apellido tiene {lastName.Trim().Replace(" ", "").Length} letras");
            // Para reamplacer cualquier carater por otro .Remplae()
            Console.WriteLine($"Mi edad es: {edad}"); // Esta es la menera mas moderna de concatenar los string en c#
          

            Console.WriteLine($"Mi altura es: {altura} cms");

            Console.WriteLine($"Mi altura en metros es: {alturaEnMetros}");

        }
    }
}

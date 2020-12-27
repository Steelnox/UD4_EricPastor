using System;

namespace UD4_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;
            bool isNotNumber = true;
            Console.WriteLine("Escribe tu nombre");
            nombre = Console.ReadLine();
            while (isNotNumber)
            {
                Console.WriteLine("Escribe tu edad");
                try
                {
                    edad = Convert.ToInt32(Console.ReadLine());
                    isNotNumber = false;
                    Console.WriteLine("Te llamas {0} y tienes {1} años", nombre, edad);

                }
                catch (FormatException)
                {
                    Console.WriteLine("No es un número");
                }
            }
        }
    }
}

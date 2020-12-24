using System;

namespace UD4_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string ciudad;
            Console.WriteLine("Escribe un nombre de persona");
            nombre = Console.ReadLine();
            Console.WriteLine("Escribe el nombre de una ciudad");
            ciudad = Console.ReadLine();
            Console.WriteLine("Hola {0} bienvenido a {1}", nombre, ciudad);
        }
    }
}

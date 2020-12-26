using System;

namespace UD4_Ex21
{
    class Program
    {
        static void Main(string[] args)
        {
            string dia = "";
            Console.WriteLine("Dime un dia de la semana y te diré si es laboral o no");
            dia = Console.ReadLine();
            dia.ToLower();

            switch (dia)
            {
                case "lunes":
                    Console.WriteLine("El lunes sí es un dia laboral");
                    break;
                case "martes":
                    Console.WriteLine("El martes sí es un dia laboral");
                    break;
                case "miercoles":
                    Console.WriteLine("El miercoles sí es un dia laboral");
                    break;
                case "jueves":
                    Console.WriteLine("El jueves sí es un dia laboral");
                    break;
                case "viernes":
                    Console.WriteLine("El viernes sí es un dia laboral");
                    break;
                case "sabado":
                    Console.WriteLine("El sabado no es un dia laboral");
                    break;
                case "domingo":
                    Console.WriteLine("El domingo no es un dia laboral");
                    break;
                default:
                    Console.WriteLine("El dia introducido no existe");
                    break;
            }
        }
    }
}

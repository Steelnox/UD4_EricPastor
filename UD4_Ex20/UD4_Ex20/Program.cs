using System;

namespace UD4_Ex20
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadVentas = 0;
            float precioActual = 0;
            float precioTotal = 0;
            bool correcto = false;
            Console.WriteLine("Dime el numero de ventas que has realizado");
            while (!correcto)
            {
                try
                {
                    cantidadVentas = Convert.ToInt32(Console.ReadLine());
                    correcto = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Numero de ventas incorrecto. Vuelve a introducirlo");
                }
            }
            for (int i = 1; i <= cantidadVentas; i++)
            {
                correcto = false;
                Console.WriteLine("Introduce el precio de la venta numero {0}", i);
                while (!correcto)
                {
                    try
                    {
                        precioActual = Convert.ToSingle(Console.ReadLine());
                        correcto = true;                    
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Precio incorrecto. Vuelve a intentarlo");
                    }
                }
                
                precioTotal += precioActual;
            }

            Console.WriteLine("El precio total de tus ventas es " + precioTotal);
        }
    }
}

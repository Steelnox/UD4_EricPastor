using System;

namespace UD4_Ex16
{
    class Program
    {
        static void Main(string[] args)
        {
            const int IVA = 21;
            float precio = 0;
            float precioIVA = 0;
            float precioFinal = 0;
            bool correcto = false;
            Console.WriteLine("Introduce un precio por teclado y te devuelvo el precio con IVA incluido");
            while (!correcto)
            {
                try
                {
                    precio = Convert.ToSingle(Console.ReadLine());
                    correcto = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("El numero no es correcto. Vuelve a intentarlo de nuevo");
                }
            }

            precioIVA = precio * IVA / 100;
            precioFinal = precio + precioIVA;

            Console.WriteLine("El precio del producto sin IVA es {0} y con IVA es {1}", precio, precioFinal);
        }
    }
}

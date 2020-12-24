using System;

namespace UD4_Ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            double radio = 0;
            double area = 0;
            bool correcto = false;
            Console.WriteLine("Escribe el radio del circulo y te daré el área");
            while (!correcto)
            {
                try
                {
                    radio = Convert.ToDouble(Console.ReadLine());
                    if(radio <= 0)
                    {
                        Console.WriteLine("Radio incorrecto. Vuelve a intentarlo");
                    }
                    else
                    {
                        correcto = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Radio incorrecto. Vuelve a intentarlo");
                }
            }

            area = Math.PI * Math.Pow(radio, 2);
            Console.WriteLine("El área del circulo es {0}", area);
        }
    }
}

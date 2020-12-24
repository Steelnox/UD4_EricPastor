using System;

namespace UD4_Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0;
            int numero2 = 0;
            bool isNotNumber = true;
            while (isNotNumber)
            {
                try
                {
                    Console.WriteLine("Escribe un numero");
                    numero1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escribe otro numero");
                    numero2 = Convert.ToInt32(Console.ReadLine());
                    isNotNumber = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("No es un número, vuelve a escribir los 2 numeros");
                }
            }
            if(numero1 > numero2)
            {
                Console.WriteLine("{0} es más grande que {1}", numero1, numero2);
            }
            else if(numero2 > numero1)
            {
                Console.WriteLine("{0} es más grande que {1}", numero2, numero1);
            }
            else
            {
                Console.WriteLine("{0} y {1} son iguales", numero1, numero2);
            }
        }
    }
}

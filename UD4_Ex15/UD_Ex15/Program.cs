using System;

namespace UD_Ex15
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            bool correcto = false;
            Console.WriteLine("Introduce un numero y te diré si es divisible entre 2");
            while (!correcto)
            {
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                    correcto = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("El numero no es correcto. Vuelve a intentarlo");
                }
            }

            if(num % 2 == 0)
            {
                Console.WriteLine("El numero {0} es divisible entre 2", num);
            }
            else 
            {
                Console.WriteLine("El numero {0} no es divisible entre 2", num);
            }
        }
    }
}

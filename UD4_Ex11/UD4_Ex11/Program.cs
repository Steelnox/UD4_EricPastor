using System;

namespace UD4_Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 27;
            int num2 = 99;

            if(num1 > num2)
            {
                Console.WriteLine("{0} es mayor que {1}", num1, num2);
            }
            else if(num2 > num1)
            {
                Console.WriteLine("{0} es mayor que {1}", num2, num1);
            }
            else 
            {
                Console.WriteLine("Los dos numeros son iguales");
            }
        }
    }
}

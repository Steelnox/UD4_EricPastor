using System;

namespace UD4_Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else if(i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

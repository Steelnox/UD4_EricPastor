using System;

namespace UD4_Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreDia = "";
            string[] diasNoFinDeSemana = { "lunes", "martes", "miercoles", "jueves", "viernes" };
            string[] diasFinDeSemana = { "sabado", "domingo" };
            bool FinDeSemana = false;
            bool error = true;

            while (error)
            {
                Console.WriteLine("Escribe un dia de la semana y te diré si es fin de semana o no");
                nombreDia = Console.ReadLine();
                for (int i = 0; i < diasNoFinDeSemana.Length; i++)
                {
                    if (nombreDia == diasNoFinDeSemana[i])
                    {
                        FinDeSemana = false;
                        error = false;
                    }
                }
                for (int j = 0; j < diasFinDeSemana.Length; j++)
                {
                    if (nombreDia == diasFinDeSemana[j])
                    {
                        FinDeSemana = true;
                        error = false;
                    }
                }
                if (error)
                {
                    Console.WriteLine("Tu nombre de dia de la semana no corresponde con ningún nombre de dia de la semana. Vuelve a intentarlo");
                }
            }
            if (FinDeSemana)
            {
                Console.WriteLine("{0} es fin de semana", nombreDia);
            }
            else
            {
                Console.WriteLine("{0} no es fin de semana", nombreDia);
            }
        }
    }
}

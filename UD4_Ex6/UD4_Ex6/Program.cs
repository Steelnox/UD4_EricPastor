using System;

namespace UD4_Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool correcto = false;
            float precio = 0;
            string formaPago = "";
            double cuenta = 0;
            bool cuentaCorrecta = false;

            while (!correcto)
            {
                Console.WriteLine("Introduce un precio");
                try
                {
                    precio = Convert.ToSingle(Console.ReadLine());
                    if (precio > 0)
                    {
                        correcto = true;
                    }
                    else
                    {
                        Console.WriteLine("No es un precio correcto. Vuelve a intentarlo");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("No es un precio correcto. Vuelve a intentarlo");
                }
            }
            correcto = false;
            while (!correcto)
            {
                Console.WriteLine("Introduce forma de pago. Efectivo o Tarjeta");
                formaPago = Console.ReadLine().ToLower();
                if(formaPago == "efectivo")
                {
                    Console.WriteLine("Ha efectuado una compra de {0} euros. Gracias por su compra.", precio);
                    correcto = true;
                }
                else if(formaPago == "tarjeta")
                {
                    while (!cuentaCorrecta)
                    {
                        Console.WriteLine("Escribe tu numero de cuenta (solo numeros)");
                        try
                        {
                            cuenta = Convert.ToDouble(Console.ReadLine());
                            cuentaCorrecta = true;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Numero de cuenta incorrecto");
                        }
                    }

                    Console.WriteLine("Ha efectuado una compra de {0} euros a la cuenta {1}. Gracias por su compra.", precio, cuenta);
                    correcto = true;
                }
                else
                {
                    Console.WriteLine("Forma de pago incorrecta. Vuelve a intentarlo");
                }
            }
        }
    }
}

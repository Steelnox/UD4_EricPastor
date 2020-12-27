using System;

namespace UD4_Ex23
{
    class Program
    {
        static void Main(string[] args)
        {
            int operando1 = 0;
            int operando2 = 0;
            int resultado = 0;
            string signo = "";
            bool correcto = false;

            Console.WriteLine("Bienvenid@ a CALCULADORAINVERSA");
            Console.WriteLine("Escribe el primer operando");
            while (!correcto){
                try
                {
                    operando1 = Convert.ToInt32(Console.ReadLine());
                    correcto = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Operando incorrecto. Vuelve a intentarlo");
                }
            }
            correcto = false;
            Console.WriteLine("Escribe el segundo operando");
            while (!correcto)
            {
                try
                {
                    operando2 = Convert.ToInt32(Console.ReadLine());
                    correcto = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Operando incorrecto. Vuelve a intentarlo");
                }
            }
            Console.WriteLine("Ahora introduce un signo aritmético, los signos disponibles son los siguientes:");
            Console.WriteLine("+ para realizar una suma");
            Console.WriteLine("- para realizar una resta");
            Console.WriteLine("* para realizar una multiplicación");
            Console.WriteLine("/ para realizar una división");
            Console.WriteLine("^ para que el primer operando sea la base y el segundo operando sea el exponente de una potencia");
            Console.WriteLine("% para realizar un módulo y que la operación te de el resto de la división entre el primer operando y el segundo operando");
            Console.WriteLine("¿Que signo quieres?");
            signo = Console.ReadLine();
            switch (signo)
            {
                case "+":
                    resultado = operando1 + operando2;
                    break;
                case "-":
                    resultado = operando1 - operando2;
                    break;
                case "*":
                    resultado = operando1 * operando2;
                    break;
                case "/":
                    resultado = operando1 / operando2;
                    break;
                case "^":
                    resultado = Convert.ToInt32(Math.Pow(operando1, operando2));
                    break;
                case "%":
                    resultado = operando1 % operando2;
                    break;
                default:
                    Console.WriteLine("Operación incorrecta. Vuelve a intentarlo más tarde.");
                    correcto = false;
                    break;
            }
            if (correcto)
            {
                Console.WriteLine("El resultado de la operación con signo {0} es {1}", signo, resultado);
            }
        }
    }
}

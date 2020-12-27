using System;

namespace UD4_Ex22
{
    class Program
    {
        static void Main(string[] args)
        {
            string contraseña = "";
            string contraseñaCorrecta = "holamundo";
            string usuario = "";
            bool correcto = false;
            int intentos = 0;

            Console.WriteLine("Introduce tu nombre de usuario");
            usuario = Console.ReadLine();
            Console.WriteLine("Introduce tu contraseña " + usuario);
            while (!correcto && intentos < 3)
            {
                contraseña = Console.ReadLine();
                if(contraseña == contraseñaCorrecta)
                {
                    correcto = true;
                }
                else
                {
                    Console.WriteLine("Contraseña incorrecta. Vuelve a intentarlo.");
                    intentos++;
                }
            }
            if (correcto)
            {
                Console.WriteLine("Enhorabuena usuario " + usuario);
            }
            else
            {
                Console.WriteLine("Has fallado 3 veces. Vuelve a intentarlo más tarde");
            }
        }
    }
}

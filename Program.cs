using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static float LeFloat(string mensagem)
        {
            Console.WriteLine(mensagem);

            float numero = 0;
            string? leitura = Console.ReadLine();

            if (float.TryParse(leitura, out numero) == false)
            {
                Console.WriteLine("AVISO: O número não foi lido corretamente, considerando como 0.");
            }

            return numero;
        }
    }
}
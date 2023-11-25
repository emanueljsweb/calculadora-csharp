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
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("AVISO: O número não foi lido corretamente, considerando como 0.");
                Console.ResetColor();
            }

            return numero;
        }

        static void Soma()
        {
            Console.Clear();

            float v1 = LeFloat("Digite o primeiro valor:");
            float v2 = LeFloat("Digite o segundo valor:");

            float resultado = v1 + v2;

            Console.WriteLine($"O resultado da soma é {resultado}.");
            Console.Write("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        static void Subtracao()
        {
            Console.Clear();

            float v1 = LeFloat("Digite o primeiro valor:");
            float v2 = LeFloat("Digite o segundo valor:");

            float resultado = v1 - v2;

            Console.WriteLine($"O resultado da subtração é {resultado}.");
            Console.Write("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            float v1 = LeFloat("Digite o primeiro valor:");
            float v2 = LeFloat("Digite o segundo valor:");

            float resultado = v1 * v2;

            Console.WriteLine($"O resultado da multiplicação é {resultado}.");
            Console.Write("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }
}
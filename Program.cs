using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
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

        static short LeShort(string mensagem)
        {
            Console.WriteLine(mensagem);

            string? leitura = Console.ReadLine();
            short numero = 0;

            if (short.TryParse(leitura, out numero))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("AVISO: O número não foi lido corretamente, considerando como 0.");
                Console.ResetColor();
            }

            return numero;
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Olá! Qual operação deseja efetuar?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine();

            short opcao = LeShort("Digite a opção desejada:");

            switch (opcao)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                default: Menu(); break;
            }
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
            Menu();
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
            Menu();
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
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            float v1 = LeFloat("Digite o primeiro valor:");
            float v2 = LeFloat("Digite o segundo valor");

            float resultado = v1 / v2;

            Console.WriteLine($"O resultado da divisão é {resultado}.");
            Console.Write("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
            Menu();
        }
    }
}
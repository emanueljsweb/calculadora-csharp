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

            if (short.TryParse(leitura, out numero) == false)
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
            Console.WriteLine("5 - Porcentagem");
            Console.WriteLine("6 - Fórmula de Bháskara");
            Console.WriteLine("7 - Sair do Programa");
            Console.WriteLine();

            short opcao = LeShort("Digite a opção desejada:");

            switch (opcao)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: Porcentagem(); break;
                case 6: Bhaskara(); break;
                case 7: System.Environment.Exit(0); break;
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

        static void Porcentagem()
        {
            Console.Clear();

            float valor = LeFloat("Digite o valor:");
            float porcentagem = LeFloat("Digite o percentual que você deseja desse valor:");

            float resultado = valor * (porcentagem / 100);

            Console.WriteLine($"{porcentagem}% de {valor} é igual a {resultado}.");
            Console.Write("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
            Menu();
        }

        static void Bhaskara()
        {
            Console.Clear();

            Console.WriteLine("Uma equação do segundo grau apresenta o formato: ax² + bx + c. Em seguida, insira apenas os valores dos parâmetros, isto é, apenas números e sinais (+ e -).");
            Console.WriteLine();

            float a = LeFloat("Digite o valor de A:");
            float b = LeFloat("Digite o valor de B:");
            float c = LeFloat("Digite o valor de C:");

            float delta = (float)Math.Pow(b, 2) - 4 * a * c;
            float x1 = (float)((b * -1) + Math.Sqrt(delta)) / 2 * a;
            float x2 = (float)((b * -1) - Math.Sqrt(delta)) / 2 * a;

            string resultado;
            if (delta > 0)
                resultado = $"As raízes são {x1} e {x2}, sendo delta igual a {delta}.";
            else if (delta == 0)
                resultado = $"A raiz da equação é {x1}, sendo delta igual a {delta}.";
            else
                resultado = $"Não existem raízes reais para essa equação, sendo delta igual a {delta}.";

            Console.WriteLine(resultado);
            Console.Write("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
            Menu();
        }
    }
}
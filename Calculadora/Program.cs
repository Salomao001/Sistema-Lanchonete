using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("1 - SOMA");
            Console.WriteLine("2 - SUBTRAÇÃO");
            Console.WriteLine("3 - MULTIPLICAÇÃO");
            Console.WriteLine("4 - DIVISÃO");
            Console.WriteLine("0 - EXIT");
            Console.WriteLine("-------------------");

            Console.Write("Selecione: ");
            short opcao = short.Parse(Console.ReadLine());


            switch (opcao)
            {
                case 1:
                    Soma();
                    break;

                case 2:
                    Subtracao();
                    break;

                case 3:
                    Multiplicacao();
                    break;

                case 4:
                    Divisao();
                    break;

                case 0:
                    System.Environment.Exit(0);
                    break;

                default:
                    Menu();
                    break;
            }
        }

        static void Soma()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            double valor1 = double.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            double valor2 = double.Parse(Console.ReadLine());

            double resultado = valor1 + valor2;
            Console.WriteLine($"\nO resultado é {resultado}");

            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            double valor1 = double.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            double valor2 = double.Parse(Console.ReadLine());

            double resultado = valor1 - valor2;
            Console.WriteLine($"\nO resultado é {resultado}");

            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            double valor1 = double.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            double valor2 = double.Parse(Console.ReadLine());

            double resultado = valor1 * valor2;
            Console.WriteLine($"\nO resultado é {resultado}");

            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            double valor1 = double.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            double valor2 = double.Parse(Console.ReadLine());

            double resultado = valor1 / valor2;
            Console.WriteLine($"\nO resultado é {resultado}");

            Console.ReadKey();
            Menu();
        }
    }
}
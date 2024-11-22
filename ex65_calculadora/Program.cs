using System;

namespace CalculadoraPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            bool continuar = true;

            while (continuar)
            {
                try
                {
                    // Mostrar o menu e escolher a operação
                    MostrarMenu();
                    Console.Write("Digite o número da operação: ");
                    int escolha = int.Parse(Console.ReadLine());

                    if (escolha == 5)
                    {
                        continuar = false;
                        Console.WriteLine("Encerrando o programa.");
                    }
                    else
                    {
                        ExecutarOperacao(escolha, calculadora);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro: Entrada inválida. Por favor, insira um número válido.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static void MostrarMenu()
        {
            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1. Somar");
            Console.WriteLine("2. Subtrair");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Sair");
        }

        private static (double, double) LerNumeros()
        {
            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());// ou  num1=Convert.ToDouble(Console.ReadLine());


            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            return (num1, num2);
        }

        private static void ExecutarOperacao(int opcao, Calculadora calculadora)
        {
            var (num1, num2) = LerNumeros();
            double resultado;

            switch (opcao)
            {
                case 1:
                    resultado = calculadora.Somar(num1, num2);
                    Console.WriteLine($"Resultado da Soma: {resultado}");
                    break;
                case 2:
                    resultado = calculadora.Subtrair(num1, num2);
                    Console.WriteLine($"Resultado da Subtração: {resultado}");
                    break;
                case 3:
                    resultado = calculadora.Multiplicar(num1, num2);
                    Console.WriteLine($"Resultado da Multiplicação: {resultado}");
                    break;
                case 4:
                    resultado = calculadora.Dividir(num1, num2);
                    Console.WriteLine($"Resultado da Divisão: {resultado}");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}

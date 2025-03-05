using System;

class Calculadora
{
    static void Main()
    {
        Console.Write("Digite o primeiro número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("\nQual operação você deseja realizar?");
        Console.WriteLine("Digite 5 para Multiplicação");
        Console.WriteLine("Digite 6 para Divisão");

        int escolha = Convert.ToInt32(Console.ReadLine());

        switch (escolha)
        {
            Console.WriteLine("Digite o primeiro número:");
            int primeiroNumero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            int segundoNumero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o número correspondente à operação: (1 - adição, 2 - subtração)");
            int operacao = Convert.ToInt32(Console.ReadLine());

            switch (operacao)
            {
                case 1:
                    Console.WriteLine(primeiroNumero + segundoNumero);
                    break;
                case 2:
                    Console.WriteLine(primeiroNumero - segundoNumero);
                    break;
                default:
                    Console.WriteLine("Operação inválida. Tente novamente.");
                    break;
            }
        }
    }
            case 5:
                Console.WriteLine("Multiplicação: " + (num1 * num2));
                break;

            case 6:
                Console.WriteLine("Divisão: " + (num1 / num2));
                break;

            default:
                Console.WriteLine("Escolha inválida! Por favor, insira um número entre 5 e 6.");
                break;
        }
    }


 master
}
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
        Console.WriteLine("Digite 1 para Adição");
        Console.WriteLine("Digite 2 para Subtração");

        int escolha = Convert.ToInt32(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                Console.WriteLine("Soma: " + (num1 + num2));
                break;
                
            case 2:
                Console.WriteLine("Subtração: " + (num1 - num2));
                break;

            case 5:
                Console.WriteLine("Multiplicação: " + (num1 * num2));
                break;

            case 6:
                if (num2 == 0)
                {
                    Console.WriteLine("Erro: Não é possível dividir por zero.");
                }
                else
                {
                    Console.WriteLine("Divisão: " + (num1 / num2));
                }
                break;

            default:
                Console.WriteLine("Escolha inválida! Por favor, insira um número entre 1, 2, 5 e 6.");
                break;
        }
    }
}

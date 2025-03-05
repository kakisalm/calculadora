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


}
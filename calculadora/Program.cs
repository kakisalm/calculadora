  using System;

  class Calculadora
  {
    static void Main()
    {
       

        Console.Write("Digite o primeiro número: ");

        double num1 = Convert.ToDouble(Console.ReadLine());

        while (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Entrada inválida! Por favor, insira um número válido.");

            Console.Write("Digite o primeiro número: ");
        }

        Console.Write("Digite o segundo número: ");

        double num2 = Convert.ToDouble(Console.ReadLine());

        while (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Entrada inválida! Por favor, insira um número válido.");

            Console.Write("Digite o segundo número: ");
        }

        Console.WriteLine("\nEscolha a operação desejada:");

        Console.WriteLine("Multiplicação: " + (num1 * num2));

        if (num2 != 0)

            Console.WriteLine("Divisão: " + (num1 / num2));

        else

        Console.WriteLine("Erro: Divisão por zero não é permitida.");

        Console.WriteLine("3 - Multiplicação");

        Console.WriteLine("4 - Divisão");

        int escolha;
        while (true)

        {
            Console.Write("Digite o número da operação (1-4): ");

            if (int.TryParse(Console.ReadLine(), out escolha) && escolha >= 1 && escolha <= 4)
            {
                break;
            }

            else
            {
                Console.WriteLine("Escolha inválida! Por favor, insira um número entre 1 e 4.");
            }

        }

        switch (escolha)
        {

            case 3:
                Console.WriteLine("Resultado da multiplicação: " + (num1 * num2));

                break;

            case 4:

                if (num2 != 0)
                {
                    Console.WriteLine("Resultado da divisão: " + (num1 / num2));
                }

                else
                {
                    Console.WriteLine("Erro: Divisão por zero não é permitida.");
                }

                break;

            default:
                Console.WriteLine("Erro: Operação não reconhecida.");

                break;
        }

    }

}


 
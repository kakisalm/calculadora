namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
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
}
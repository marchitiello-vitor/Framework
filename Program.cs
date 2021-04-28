using System;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu Nome? ");
            string primeiroNome = Console.ReadLine();

            Console.WriteLine("Bom dia " + primeiroNome + '!');
            Console.WriteLine("Deseja sua media, certo?");

            Console.Write("Digite sua primeira nota:");
            int PrimeiroNumero = int.Parse(Console.ReadLine());

            Console.Write("Digite sua segunda nota:");
            int SegundoNumero = int.Parse(Console.ReadLine());

            Console.Write("Digite sua terceira nota:");
            int TerceiroNumero = int.Parse(Console.ReadLine());

            int soma = PrimeiroNumero + SegundoNumero + TerceiroNumero;
            int divisao = soma / 3;

            Console.WriteLine("A sua media é: " + divisao);

            if (divisao >5)
            {
                Console.WriteLine("Voce esta Aprovado");
            }
            else
            {
                Console.WriteLine("Voce esta Reprovado");
            }
        }
    }
}

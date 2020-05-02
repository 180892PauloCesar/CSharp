using System;

namespace Somar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número:");
            decimal numero1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número:");
            decimal numero2 = int.Parse(Console.ReadLine());
            decimal soma = numero1 + numero2;
            Console.WriteLine("A soma dos valores digitados " + numero1 + " e " + numero2 + " é: " + soma);
        }
    }
}

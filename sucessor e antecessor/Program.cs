using System;

namespace sucessor_e_antecessor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int sucessor;
            int antecessor;

            Console.Write("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            antecessor = numero -1;
            sucessor = numero +1;

            Console.Write("O número " +numero + " tem como antecessor " + antecessor + " e como sucessor " +sucessor +".");
        }
    }
}

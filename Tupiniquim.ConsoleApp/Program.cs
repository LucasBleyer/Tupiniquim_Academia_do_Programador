using System;

namespace Tupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tupiniquim I");
            
            Console.WriteLine("\r\nDigite as Coordenadas para Tupiniquim I mapear, por exemplo = 0 0");
            Console.Write("Coordenadas: ");
            string coordenadas = Console.ReadLine();

            Console.WriteLine("\r\nDigite a Posição Inicial para Tupiniquim I começar, por exemplo = 0 0 N");
            Console.WriteLine("N = Norte, S = Sul, L = Leste, O = Oeste");
            Console.Write("Posição Inicial: ");
            string posicao_inicial = Console.ReadLine();

         
        }
    }
}

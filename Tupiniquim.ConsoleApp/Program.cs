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
            string str_coordenadas = Console.ReadLine();
            char[] coordenadas = new char[str_coordenadas.Length];
            for (int i = 0; i < str_coordenadas.Length; i++)
            {
                coordenadas[i] = str_coordenadas [i];
            }

            Console.WriteLine("\r\nDigite a Posição Inicial para Tupiniquim I começar, por exemplo = 0 0 N");
            Console.WriteLine("N = Norte, S = Sul, L = Leste, O = Oeste");
            Console.Write("Posição Inicial: ");
            string str_posicao_inicial = Console.ReadLine();
            char[] posicao_inicial = new char[str_posicao_inicial.Length];
            for (int i = 0; i < str_posicao_inicial.Length; i--)
            {
                posicao_inicial[i] = str_posicao_inicial[i];
            }
            
            
        }
    }
}

using System;

namespace Tupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarção de variáveis
            string str_quadrilatero, str_posicao_inicial, str_movimentos;
            int menor_x = 0, menor_y = 0, maior_x, maior_y, posicao_x_robo, posicao_y_robo; ;
            char bussola;

            //entrada de dados
            Console.Write("Tamanho da área do quadrilátero, por exemplo 5 5: ");
            str_quadrilatero = Console.ReadLine();
            string[] quadrilatero = str_quadrilatero.Split(' ');
            maior_x = int.Parse(quadrilatero[0]);
            maior_y = int.Parse(quadrilatero[1]);

            Console.WriteLine("\r\nInforme a Posição Inicial do Tupiniquim I, por exemplo 5 5 N");
            Console.WriteLine("N = Norte, S = Sul, L = Leste, O = Oeste");
            Console.Write("Posição Inicial: ");
            str_posicao_inicial = Console.ReadLine();
            string[] posicao_inicial = str_posicao_inicial.Split(' ');
            posicao_x_robo = int.Parse(posicao_inicial[0]);
            posicao_y_robo = int.Parse(posicao_inicial[1]);
            bussola = Convert.ToChar(posicao_inicial[2]);

            Console.WriteLine("\r\nInforme os comandos a serem seguidos pelo Tupiniquim I, por exemplo MEDM");
            Console.WriteLine("M = Mover, E = Esquerda, D = Direita");
            Console.WriteLine("Movimentações: ");
            str_movimentos = Console.ReadLine();

            //processamento
            
            




            //saida
        }
    }
}

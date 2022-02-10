using System;

namespace Tupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //declarção de variáveis
            string str_quadrilatero, str_posicao_inicial, str_movimento;
            int menor_x = 0, menor_y = 0, maior_x, maior_y, posicao_x_robo, posicao_y_robo; ;
            char bussola;

        //entrada de dados
            Console.Write("Tamanho da área do quadrilátero, por exemplo 5 5: ");
            str_quadrilatero = Console.ReadLine();
            string[] quadrilatero = str_quadrilatero.Split(' ');
            maior_x = int.Parse(quadrilatero[0]);
            maior_y = int.Parse(quadrilatero[1]);

            Console.WriteLine("\r\nInforme a Posição Inicial do Tupiniquim I, por exemplo 1 2 N");
            Console.WriteLine("N = Norte, S = Sul, L = Leste, O = Oeste");
            Console.Write("Posição Inicial: ");
            str_posicao_inicial = Console.ReadLine();
            string[] posicao_inicial = str_posicao_inicial.Split(' ');
            posicao_x_robo = int.Parse(posicao_inicial[0]);
            posicao_y_robo = int.Parse(posicao_inicial[1]);
            bussola = Convert.ToChar(posicao_inicial[2]);

            Console.WriteLine("\r\nInforme os comandos a serem seguidos pelo Tupiniquim I, por exemplo EMEMEMEMM");
            Console.WriteLine("M = Mover, E = Esquerda, D = Direita");
            Console.WriteLine("Movimentações: ");
            str_movimento = Console.ReadLine();
            char[] ordens = str_movimento.ToCharArray();
        //processamento
            for (int i = 0; i < ordens.Length; i++)
            {
                if (ordens[i] == 'E')
                {
                    switch (bussola)
                    {
                        case 'N':
                            bussola = 'O';
                            break;
                        case 'S':
                            bussola = 'L';
                            break;
                        case 'L':
                            bussola = 'N';
                            break;
                        case 'O':
                            bussola = 'S';
                            break;
                    }
                }
                if (ordens[i] == 'D')
                {
                    switch (bussola)
                    {
                        case 'N':
                            bussola = 'L';
                            break;
                        case 'S':
                            bussola = 'O';
                            break;
                        case 'L':
                            bussola = 'S';
                            break;
                        case 'O':
                            bussola = 'N';
                            break;
                    }
                }
                if (ordens[i] == 'M')
                {
                    if (bussola == 'N' && maior_y >= (posicao_y_robo + 1))
                    {
                        posicao_y_robo++;
                    }
                    else if (bussola == 'S' && menor_y <= (posicao_y_robo - 1))
                    {
                        posicao_y_robo--;
                    }
                    else if (bussola == 'L' && maior_x >= (posicao_x_robo + 1))
                    {
                        posicao_x_robo++;
                    }
                    else if (bussola == 'O' && menor_x <= (posicao_x_robo - 1))
                    {
                        posicao_x_robo--;
                    }
                }
            }
        //saida
            Console.WriteLine(posicao_x_robo + " " + posicao_y_robo + " " + bussola);
        }
    }
}
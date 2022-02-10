using System;

namespace Tupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(
string[] args)
        {
            Console.WriteLine("Tupiniquim I");
            Console.Write("Digite a coordenada x do canto superior da área: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a coordenada y do canto superior da área: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double posicao_inicial_x = 0;
            Console.Write("Posição Inicial X: ");
            posicao_inicial_x = Convert.ToDouble(Console.ReadLine());
            double posicao_inicial_y = 0;
            Console.Write("Posição Inicial Y: ");
            posicao_inicial_y = Convert.ToDouble(Console.ReadLine());

            Console.Write("Direção a ser seguida pelo Tupiniquim I (N = Norte, S= Sul, L = Leste, O = Oeste): ");
            char bussola = Convert.ToChar(Console.ReadLine());
            Console.Write("Movimentos a serem seguidos pelo Tupiniquim I(M = Mover, E = Esquerda, D = Direita): ");
            string movimentos = Convert.ToString(Console.ReadLine());
            char[] ordens = movimentos.ToCharArray();
            for (int i = 0; i < ordens.Length; i++)
            {
                while (ordens[i] == 'E')
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
                    break;
                }

                while (ordens[i] == 'D')
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
                    break;
                }

                while (ordens[i] == 'M')
                {
                    if (bussola == 'N')
                    {
                        posicao_inicial_y++;
                        break;
                    }
                    else
                    {
                        if (bussola == 'L')
                        {
                            posicao_inicial_x++;
                            break;
                        }
                        else
                        {
                            if (bussola == 'S')
                            {
                                posicao_inicial_y--;
                                break;
                            }
                            else
                            {
                                if (bussola == 'O')
                                {
                                    posicao_inicial_x--;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(posicao_inicial_x + " " + posicao_inicial_y + " " + bussola);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha
{
    class Program
    {
        static String[,] matrix = new String[,] { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };
        static String jogada;
        static int numJogada;
        static bool vencedor = false;
        static int jogador = 1;
        static int jogadorAnt = 0;

        static void Main(string[] args)
        {

            while (!vencedor)
            {
                numJogada = 0;

                if (jogadorAnt != jogador)
                {
                    Console.WriteLine("Jogo da velha");
                    Console.WriteLine("| {0} | {1} | {2} |", matrix[0, 0], matrix[0, 1], matrix[0, 2]);
                    Console.WriteLine("| {0} | {1} | {2} |", matrix[1, 0], matrix[1, 1], matrix[1, 2]);
                    Console.WriteLine("| {0} | {1} | {2} |", matrix[2, 0], matrix[2, 1], matrix[2, 2]);

                }
                Console.WriteLine("\nJogador {0} digite uma posição:", jogador);
                jogada = Console.ReadLine();

                jogadorAnt = jogador;


                if (!int.TryParse(jogada, out numJogada))
                {
                    Console.WriteLine("Digite um valor numérico");
                }

                switch (numJogada)
                {
                    case 1:

                        if (matrix[0, 0] != "1")
                        {
                            Console.WriteLine("Posição Inválida, tente outra");
                        }
                        else
                        {
                            if (jogador == 1)
                            {
                                matrix[0, 0] = "O";
                                jogador = 2;
                            }
                            else
                            {
                                matrix[0, 0] = "X";
                                jogador = 1;
                            }
                            Console.Clear();
                        }

                        break;
                    case 2:
                        if (matrix[0, 1] != "2")
                        {
                            Console.WriteLine("Posição Inválida, tente outra");
                        }
                        else
                        {
                            if (jogador == 1)
                            {
                                matrix[0, 1] = "O";
                                jogador = 2;
                            }
                            else
                            {
                                matrix[0, 1] = "X";
                                jogador = 1;
                            }
                            Console.Clear();
                        }

                        break;
                    case 3:
                        if (matrix[0, 2] != "3")
                        {
                            Console.WriteLine("Posição Inválida, tente outra");
                        }
                        else
                        {
                            if (jogador == 1)
                            {
                                matrix[0, 2] = "O";
                                jogador = 2;
                            }
                            else
                            {
                                matrix[0, 2] = "X";
                                jogador = 1;
                            }
                            Console.Clear();
                        }

                        break;
                    case 4:
                        if (matrix[1, 0] != "4")
                        {
                            Console.WriteLine("Posição Inválida, tente outra");
                        }
                        else
                        {
                            if (jogador == 1)
                            {
                                matrix[1, 0] = "O";
                                jogador = 2;
                            }
                            else
                            {
                                matrix[1, 0] = "X";
                                jogador = 1;
                            }
                            Console.Clear();
                        }

                        break;
                    case 5:
                        if (matrix[1, 1] != "5")
                        {
                            Console.WriteLine("Posição Inválida, tente outra");
                        }
                        else
                        {
                            if (jogador == 1)
                            {
                                matrix[1, 1] = "O";
                                jogador = 2;
                            }
                            else
                            {
                                matrix[1, 1] = "X";
                                jogador = 1;
                            }
                            Console.Clear();
                        }

                        break;
                    case 6:
                        if (matrix[1, 2] != "6")
                        {
                            Console.WriteLine("Posição Inválida, tente outra");
                        }
                        else
                        {
                            if (jogador == 1)
                            {
                                matrix[1, 2] = "O";
                                jogador = 2;
                            }
                            else
                            {
                                matrix[1, 2] = "X";
                                jogador = 1;
                            }
                            Console.Clear();
                        }

                        break;
                    case 7:
                        if (matrix[2, 0] != "7")
                        {
                            Console.WriteLine("Posição Inválida, tente outra");
                        }
                        else
                        {
                            if (jogador == 1)
                            {
                                matrix[2, 0] = "O";
                                jogador = 2;
                            }
                            else
                            {
                                matrix[2, 0] = "X";
                                jogador = 1;
                            }
                            Console.Clear();
                        }

                        break;
                    case 8:
                        if (matrix[2, 1] != "8")
                        {
                            Console.WriteLine("Posição Inválida, tente outra");
                        }
                        else
                        {
                            if (jogador == 1)
                            {
                                matrix[2, 1] = "O";
                                jogador = 2;
                            }
                            else
                            {
                                matrix[2, 1] = "X";
                                jogador = 1;
                            }
                            Console.Clear();
                        }

                        break;
                    case 9:
                        if (matrix[2, 2] != "9")
                        {
                            Console.WriteLine("Posição Inválida, tente outra");
                        }
                        else
                        {
                            if (jogador == 1)
                            {
                                matrix[2, 2] = "O";
                                jogador = 2;
                            }
                            else
                            {
                                matrix[2, 2] = "X";
                                jogador = 1;
                            }
                            Console.Clear();
                        }

                        break;
                    default:
                        Console.WriteLine("Digite uma posição de 1 a 9");
                        numJogada = 0;
                        break;

                }

                vencedor = Venceu(jogadorAnt);

                if (vencedor)
                {
                    jogador = jogadorAnt;
                    break;
                }
            }

            Console.WriteLine("Jogador {0} venceu, parabéns!", jogador);

            Console.Read();
        }

        static bool Venceu(int jog)
        {
            string x;

            x = (jog == 1) ? "O" : "X";

            if (matrix[0, 0] == x && matrix[0, 1] == x && matrix[0, 2] == x)
            {
                return true;
            }

            if (matrix[1, 0] == x && matrix[1, 1] == x && matrix[1, 2] == x)
            {
                return true;
            }

            if (matrix[2, 0] == x && matrix[2, 1] == x && matrix[2, 2] == x)
            {
                return true;
            }
            //-----------------
            if (matrix[0, 0] == x && matrix[1, 0] == x && matrix[2, 0] == x)
            {
                return true;
            }

            if (matrix[0, 1] == x && matrix[1, 1] == x && matrix[2, 1] == x)
            {
                return true;
            }

            if (matrix[0, 2] == x && matrix[1, 2] == x && matrix[2, 2] == x)
            {
                return true;
            }
            //-----------------
            if (matrix[0, 0] == x && matrix[1, 1] == x && matrix[2, 2] == x)
            {
                return true;
            }

            if (matrix[2, 0] == x && matrix[1, 1] == x && matrix[0, 2] == x)
            {
                return true;
            }

            return false;
        }
    }
}

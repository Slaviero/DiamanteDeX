using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Xml;

namespace DiamanteDeX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um numero impar para representar o centro de seu diamante: ");
            int Diamante = int.Parse(Console.ReadLine());

            if (Diamante % 2 == 0)
            {
                Console.WriteLine("O numero precisa ser impar! Insira um novo valor.");
                return;
            }
            else
            {
                string[,] matriz = new string[Diamante,Diamante];
                int meioDiamante = Diamante / 2;
                Diamante--;
                int inicioDiamante = meioDiamante;
                int finalDiamante = meioDiamante;


                for (int linha = 0; linha <= meioDiamante; linha++)
                {
                    for (int coluna = 0; coluna <= Diamante; coluna++)
                    {
                        if (inicioDiamante <= coluna && coluna <= finalDiamante)
                        {                        
                           matriz[linha, coluna] = "x";
                        }
                        else
                        {
                           matriz[linha, coluna] = " ";
                        }
                       
                    }
                    inicioDiamante--;
                    finalDiamante++;
                }

                inicioDiamante++;
                finalDiamante--;

                for (int linha = meioDiamante; linha <= Diamante; linha++)
                {
                    for (int coluna = 0; coluna <= Diamante; coluna++)
                    {
                        if (inicioDiamante <= coluna && coluna <= finalDiamante)
                        {
                            matriz[linha, coluna] = "x";
                        }
                        else
                        {
                            matriz[linha, coluna] = " ";
                        }

                    }
                    inicioDiamante++;
                    finalDiamante--;
                }

                for (int l = 0; l <= Diamante; l++)
                {
                    for (int c = 0; c <= Diamante; c++)
                    {
                        Console.Write($"{matriz[l, c]}");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}



using System;
using System.Globalization;
namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.WriteLine("Entre com as dimenções da matriz: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            double[,] mat1 = new double[x, y];

            Console.WriteLine();
            Console.WriteLine(mat1.Length); /*O comando Length na matriz mostra quantos elementos a matriz tem
            no total*/
            
            Console.WriteLine(mat1.Rank); /*O comando Rank mostra a quantidade da primeira dimenção da matriz,
            ou seja de linhas que possui a matriz*/
            
            Console.WriteLine(mat1.GetLength(0)); /*O comando GetLength faz a mesma coisa que o lenght mostra
            a quantidade de linha ou colunas a diferença é que ele permite que seja possível voce escolher se
            será a quantidade da primeira dimenção[0](linhas) ou se deseja a quandidade da segunda
            dimenção[1](colunas)*/

            Console.WriteLine(mat1.GetLength(1)); /* Percorre a segunda dimenção da matriz, ou seja,
            as colunas da matriz*/
        }
    }
}

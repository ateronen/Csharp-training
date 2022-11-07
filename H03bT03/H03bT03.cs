using System;
using System.Collections;
using System.Reflection;
using System.Text;

class H03bT03
{
    static void Main(string[] args)
    {
        int i, y, num;
        int res = 0;

        int[,] tbl = new int[2,5];

        for (i = 0; i < tbl.GetLength(0); i++){
            for (y = 0; y < tbl.GetLength(1); y++)
            {
                Console.Write("Anna luku: ");
                num = int.Parse(Console.ReadLine());
                tbl[i, y] = num;
            }
        }
        i = 0;
        y = 0;

        Console.WriteLine();

        for (i = 0; i < tbl.GetLength(0); i++)
        {
            for (y = 0; y < tbl.GetLength(1); y++)
            {
                Console.Write("{0} ", tbl[i, y]);
            }
            Console.WriteLine();
        }
        Console.Write("Anna rivinumero 1-2: ");
        int row = int.Parse(Console.ReadLine());
        row = row - 1;
        Console.Write("Anna sarakenumero 1-5: ");
        int col = int.Parse(Console.ReadLine());
        col = col - 1;
        res = tbl[row, col];
        Console.WriteLine("Taulukossa rivillä " + (row = row + 1) + " ja sarakkeessa " + (col = col + 1) + " on luku " + res);
    }
}
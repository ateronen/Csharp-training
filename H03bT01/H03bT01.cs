using System;
using System.Collections;
using System.Reflection;
using System.Text;

class H03bT01
{
    static void Main(string[] args)
    {
        Random randm = new Random();
        int[] randoms = new int[10];
        int num;
        int i;


        for (i = 1; i <= randoms.Length; i = i + 1)
        {
            num = randm.Next(1, 100);
            if (randoms.Contains(num))
            {
                num = randm.Next(1, 100);
            }
            Console.WriteLine(i+". numero on: " + num);
            randoms[i-1] = num;
        }
        Console.WriteLine("");
        Array.Sort(randoms);
        int y = 1;
        foreach (int x in randoms)
        {
            Console.WriteLine(y+". numero on: "+x);
            y++;
        }
    }
}
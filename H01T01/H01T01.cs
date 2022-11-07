using System;
using System.Security.Cryptography.X509Certificates;

class H01T01
{
    static public void Main()
    {
       
        for (byte x = 0; x <= 8; x++)
        {
            Console.Write("*");
        }
            Console.WriteLine("*");
                Console.Write("*");
                    for (byte x = 8; x <= 15; x++)
                        {
                            Console.Write(" ");
                        }
                        Console.WriteLine("*");
        Console.Write("*");
        for (byte x = 15; x <= 22; x++)
        {
            Console.Write(" ");
        }
        Console.WriteLine("*");
        for (byte x = 23; x <= 32; x++)
        {
            Console.Write("*");
        }
    }
}
using System;
using System.Collections;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Text;

class H03bT06
{
    static void Main()
    {
        int negOne = -1;
        int counter = 0;

        List<int> listOfInts = new();

        while(true)
        {
            Console.Write("Insert a positive integer (-1 stops the program from running): ");
            listOfInts.Add(Convert.ToInt32(Console.In.ReadLine()));
                if (listOfInts[counter] == negOne)
                {
                    if (counter == 0)
                    {
                        Console.WriteLine("You stopped immediately so smallest or largest integer don't exist.");
                        break;
                    }
                listOfInts.RemoveAt(counter);
                    break;
                }
            counter++;
        }
        if (counter != 0)
        {
            Console.WriteLine("You inserted " + counter + " integers.");
            Console.WriteLine("The smallest was " + listOfInts.Min());
            Console.WriteLine("The largest was " + listOfInts.Max());
        }
    }
}
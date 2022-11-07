using System;
using System.Globalization;

class H03T03
{
    public static void Main(string[] args)
    {
        string ohje1 = "Anna ";
        string ohje2 = ". kokonaisluku: ";
        int []numbers = new int[6];
        float sum = 0.0f;

        for (int i = 1; i < numbers.Length; i = i + 1)
        {
            Console.WriteLine(ohje1 + i + ohje2);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        foreach (int x in numbers)
        {
            sum += x;
        }
        float mean = sum / (numbers.Length - 1);
        Console.WriteLine("Taulukossa olevien lukujen keskiarvo on " + mean.ToString(CultureInfo.CreateSpecificCulture("fi-FI")));
    }
}
using System;
using System.Globalization;
using System.Text;

class H03bT05
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Changing cultural info to match Finnish standards
        CultureInfo culture;
        if (Thread.CurrentThread.CurrentCulture.Name == "fi-Fi")
            culture = CultureInfo.CreateSpecificCulture("en-US");
        else
            culture = CultureInfo.CreateSpecificCulture("fi-Fi");

        Thread.CurrentThread.CurrentCulture = culture;
        Thread.CurrentThread.CurrentUICulture = culture;

        // The actual main program

        // Read user input
        Console.Write("Insert the circle radius (cm): ");
        double radius = double.Parse(Console.ReadLine());

        // Here we start to do the maths. Firstly, the program provides the areas of circle and outer square.
        double circle = Math.PI * (Math.Pow(radius, 2));
        double sqrOut = Math.Pow((radius * 2), 2);

        // Then the program calculates the outer green area
        double outerGreenArea = sqrOut - circle;

        // Calculates cathetus. Then program calculates area of the inner square
        double cathA = Math.Sqrt(radius * (radius / 2));
        double sqrIn = Math.Pow((cathA * 2), 2);

        // Addition of the green areas
        double greenAreaTot = outerGreenArea + sqrIn;

        // Finally, the program prints the results

        Console.WriteLine("The outer green area is: "+ Math.Round(outerGreenArea, 2) + " square cm");
        Console.WriteLine("The smaller green square's area is " + Math.Round(sqrIn, 2) + " square cm");
        Console.WriteLine("Total green area: " + Math.Round(greenAreaTot, 2) + " square cm");
    }
}
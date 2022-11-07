using System;

class H03bT04
{
    static void Main(string[] args)
    {

        int pts, i, y;
        double sum = 0;
        double[,] st_pts = new double[3,4];
        

        for (i = 0; i < st_pts.GetLength(0); i++)
        {

            for (y = 0; y < (st_pts.GetLength(1)); y++)
            {
                if (y == 3)
                {
                    st_pts[i, y] = sum;
                    sum = 0;
                    break;
                }
                Console.Write("Anna {0}. opiskelijan {1}. kokeen pisteet: ", i+1, y+1);
                pts = int.Parse(Console.ReadLine());
                st_pts[i, y] = pts;
                sum = sum + st_pts[i, y];
            }
        }
            y = 0;
            i = 0;
        for (i = 0; i < st_pts.GetLength(0); i++)
        {
            Console.Write("Opiskelijan {0} koepisteet olivat ", i + 1); 
            for (y = 0; y < (st_pts.GetLength(1)); y++)
            {
                if (y == 3)
                {
                    Console.Write("ja yhteispisteet olivat "+ string.Format("{0:0.0}", st_pts[i, y]));
                    break;
                }
                if (y < 2) 
                {
                    Console.Write(string.Format("{0:0.0}", st_pts[i, y]) +", ");
                }
                if (y == 2)
                {
                    Console.Write(string.Format("{0:0.0}", st_pts[i, y]) + " ");
                }
            }
            Console.WriteLine("");
        }
    }
}
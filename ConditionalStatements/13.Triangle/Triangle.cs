using System;
using System.Globalization;
using System.Threading;
    class Triangle
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            //getting coordinates of the 3 points
            int ax = int.Parse(Console.ReadLine());
            int ay = int.Parse(Console.ReadLine());
            int bx = int.Parse(Console.ReadLine());
            int by = int.Parse(Console.ReadLine());
            int cx = int.Parse(Console.ReadLine());
            int cy = int.Parse(Console.ReadLine());
            //getting distance between the points
            double a = Math.Sqrt((bx - cx) * (bx - cx) + (by - cy) * (by - cy));
            double b = Math.Sqrt((ax - cx) * (ax - cx) + (ay - cy) * (ay - cy));
            double c = Math.Sqrt((bx - ax) * (bx - ax) + (by - ay) * (by - ay));
            //checking if the points can form triangle and print the result and the area if yes
            if (a + b > c && a + c > b && c + b > a)
            {
                Console.WriteLine("Yes");
                double p = (a+b+c)/2;
                double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine("{0:F2}",area);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("{0:F2}",c);
            }
        }
    }


using System;

    class TheBiggestofFiveNumbers
    {
        static void Main()
        {
            int a= int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            if (a>b && a>b && a>c && a>d && a>e)
            {
                Console.WriteLine(a);
            }
            if(b>a && b>c && b>d && b>e)
            {
                Console.WriteLine(b);
            }
            if(c>a && c>b && c>d && c>e)
            {
                Console.WriteLine(c);
            }
            if(d>a && d>b && d >c && d>e)
            {
                Console.WriteLine(d);
            }
            else
            {
                Console.WriteLine(e);
            }
        }
    }


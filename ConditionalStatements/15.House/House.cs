using System;

    class House
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int half = n / 2;
            int counter = 1;
            int secondCounter = 0;
            for (int i = 1; i <= half+1; i++)
            {
                if (i==1)
                {
                    string dots = new string('.', half);
                    Console.WriteLine(dots + "*" + dots);
                    secondCounter++;
                }
                else if (i==half+1)
                {
                    string stars = new string('*', n);
                    Console.WriteLine(stars);
                }
                else
                {
                    string dots = new string('.', half-secondCounter);
                    string innerdots = new string('.', counter);
                    Console.WriteLine(dots+"*"+innerdots+"*"+dots);
                    counter+=2;
                    secondCounter++;
                }
                
            }
            for (int i = 1; i <= half; i++)
            {
                if (i!=half)
                {
                    string dots = new string('.', n / 4);
                    string innerdots = new string('.', n - (2 + 2 * (n / 4)));
                    Console.WriteLine(dots + "*" + innerdots + "*" + dots);
                } 
                else
                {
                    string dots = new string('.', n / 4);
                    string stars = new string('*', n - 2*(n / 4));
                    Console.WriteLine(dots+stars+dots);
                }
            }
               
        }
    }


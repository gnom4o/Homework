using System;

    class BonusScore
    {
        static void Main()
        {
            int score = int.Parse(Console.ReadLine());
            if(score> 0 && score<4)
            {
                score = score * 10;
                Console.WriteLine(score);
            }
            else if (score>3 && score <7)
            {
                score = score * 100;
                Console.WriteLine(score);
            }
            else if (score>6 && score<10)
            {
                score = score * 1000;
                Console.WriteLine(score);
            }
            else
            {
                Console.WriteLine("Invalid Score");
            }
        }
    }


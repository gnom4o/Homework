using System;

    class PlayIntDoubleString
    {
        static void Main()
        {
            Console.WriteLine("Please make a choice");
            Console.WriteLine("1-->int");
            Console.WriteLine("2-->double");
            Console.WriteLine("3-->string");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Please enter an int:");
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine(n+1);
                    break;
                case 2:
                    Console.Write("Please enter a double:");
                    double d = double.Parse(Console.ReadLine());
                    Console.WriteLine(d+1d);
                    break;
                case 3:
                    Console.Write("Please enter a string:");
                    string s = Console.ReadLine();
                    Console.WriteLine(s+"*");
                    break;
                default:
                    Console.WriteLine("Not a valid choice");
                    break;
            }
        }
    }


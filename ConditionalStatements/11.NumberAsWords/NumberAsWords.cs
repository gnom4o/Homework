using System;

class NumberAsWords
{
    public static void Digit(int number)
    {
        switch (number)
        {
            case 1:
                Console.Write("One");
                break;
            case 2:
                Console.Write("Two");
                break;
            case 3:
                Console.Write("Three");
                break;
            case 4:
                Console.Write("Four");
                break;
            case 5:
                Console.Write("Five");
                break;
            case 6:
                Console.Write("Six");
                break;
            case 7:
                Console.Write("Seven");
                break;
            case 8:
                Console.Write("Eight");
                break;
            case 9:
                Console.Write("Nine");
                break;
            case 0:
                Console.Write("Zero");
                break;
            default:
                Console.Write("");
                break;
        }

    }
    public static void desetici(int number)
    {
        switch (number)
        {
            case 10:
                Console.Write("Ten");
                break;
            case 20:
                Console.Write("Twenty");
                break;
            case 30:
                Console.Write("Thirty");
                break;
            case 40:
                Console.Write("Forty");
                break;
            case 50:
                Console.Write("Fifty");
                break;
            case 60:
                Console.Write("Sixty");
                break;
            case 70:
                Console.Write("Seventy");
                break;
            case 80:
                Console.Write("Eighty");
                break;
            case 90:
                Console.Write("Ninety");
                break;
            default:
                Console.Write("");
                break;
        }
    }
    public static void tenToTwenty(int number)
    {
        switch (number)
        {
           
            case 11:
                Console.Write("Eleven");
                break;
            case 12:
                Console.Write("Twelve");
                break;
            case 13:
                Console.Write("Thirteen");
                break;
            case 14:
                Console.Write("Fourteen");
                break;
            case 19:
                Console.Write("Nineteen");
                break;
            case 15:
                Console.Write("Fifteen");
                break;
            case 16:
                Console.Write("Sixteen");
                break;
            case 17:
                Console.Write("Seventeen");
                break;
            case 18:
                Console.Write("Eighteen");
                break;
            default:
                Console.Write("");
                break;
        }
    }
    static void Main()
    {
        Console.WriteLine("Please enter number between 0 and 1000");
        int number = int.Parse(Console.ReadLine());
        if (number > 999 || number < 0)
        {
            Console.WriteLine("Invalid number");
            return;
        }
        if (number < 20 && number > 9)
        {
            tenToTwenty(number);
            Console.WriteLine();
        }
        if (number < 10 & number >= 0)
        {
            Digit(number);
            Console.WriteLine();
        }
        if (number >= 20 && number < 100)
        {
            if (number % 10 == 0)
            {
                desetici(number);
                Console.WriteLine();
            }
            else
            {
                desetici(number-(number%10));
                Console.Write(" ");
                Digit(number % 10);
                Console.WriteLine();
            }
        }
        if (number>99 && number<1000)
        {
            if (number%100 ==0)
            {
                Digit(number / 100);
                Console.WriteLine(" hundred");
                Console.WriteLine();
            }
            else
            {
                if(number%10==0)
                {
                    Digit(number / 100);
                    Console.Write(" hundred and ");
                    desetici(number % 100);
                    Console.WriteLine();
                }
                else
                {
                    Digit(number / 100);
                    Console.Write(" hundred and ");
                    if (number % 100 < 20 && number % 100 > 10)
                    {
                        tenToTwenty(number % 100);
                        Console.WriteLine();
                    }
                    else
                    {
                        desetici(number % 100 - (number % 10));
                        Console.Write(" ");

                        Digit(number % 10);
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}


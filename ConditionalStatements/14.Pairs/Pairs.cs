using System;
class Pairs
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');
        int sum = 0;
        int counter = 0;
        int[] result = new int[numbers.Length/2];
        bool checker = false;
        int diff = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            
            sum = sum + Convert.ToInt32(numbers[i]);
            if (i % 2 == 1)
            {
                result[counter] = sum;
                counter++;
                sum = 0;
            }
        }
        if (result.Length == 1)
        {
            checker = true;
            sum=result[0];
        }
        else
        {
            for (int i = 1; i < result.Length; i++)
            {
                if (result[i] == result[i - 1])
                {
                    checker = true;
                    sum = result[i];
                }
                else
                {
                    if (result[i] - result[i - 1] > 0 && result[i] - result[i - 1] > diff)
                    {
                        diff = result[i] - result[i - 1];
                        checker = false;
                    }
                    else if (result[i - 1] - result[i] > 0 && result[i - 1] - result[i] > diff)
                    {
                        diff = result[i - 1] - result[i];
                        checker = false;
                    }
                }
            }
            
        }
        if (checker == true)
        {
            Console.WriteLine("Yes, value=" + sum);
        }
        else
        {
            Console.WriteLine("No, maxdiff=" + diff);
        }
    }
}


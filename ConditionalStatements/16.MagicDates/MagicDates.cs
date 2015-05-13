using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

    class MagicDates
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");
            int inputStartYear = int.Parse(Console.ReadLine());
            int inputEndYear = int.Parse(Console.ReadLine());
            string startYear = Convert.ToString(inputStartYear);
            string endYear = Convert.ToString(inputEndYear);
            int magic=int.Parse(Console.ReadLine());
            bool checker = false;
            int product = 1;
            int sum = 0;
            int number=0;
            int multiplier;
            DateTime startDate = DateTime.Parse("01-01-"+startYear);
            DateTime endDate = DateTime.Parse("31-12-"+endYear);
            
            while (startDate <= endDate)
            {
                sum = 0;
                string date = startDate.ToString("ddMMyyyy");
                for (int i = 0; i < date.Length; i++)
                {
                    
                    number = (int)char.GetNumericValue(date[i]);
                    for (int j = i+1; j < date.Length; j++)
                    {
                        multiplier = (int)char.GetNumericValue(date[j]);
                        product = number * multiplier;
                        
                        sum = sum + product;
                    }
                   
                }
                if (sum == magic)
                {
                    Console.WriteLine(startDate.ToString("dd-MM-yyyy"));
                    checker = true;
                }
                startDate=startDate.AddDays(1);
            }
            if (checker!=true)
            {
                Console.WriteLine("No");
            }
            
          
        }
    }


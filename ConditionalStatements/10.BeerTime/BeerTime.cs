using System;
using System.Globalization;
    class BeerTime
    {
        static void Main()
        {
            string hour = Console.ReadLine();
            DateTime startTime = DateTime.Parse("1:00 PM");
            DateTime endTime = DateTime.Parse("3:00 AM");
            DateTime time;
            if (DateTime.TryParseExact(hour,"hh:mm tt", CultureInfo.CreateSpecificCulture("en-US"), DateTimeStyles.None, out time))
            {
                
                if (time > startTime || time < endTime)
                {
                    Console.WriteLine("BeerTime");
                }
                else
                {
                    Console.WriteLine("Not beer time");
                }
            }
            else
            {
                Console.WriteLine("Invalid time format");
            }
        }
    }


using System;
using System.Collections.Generic;

    class BitKiller
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            byte[] numbers = new byte[n];
            int result=0;
            int bitcounter = 0;
            int killbit = 1;
            List<int> bits = new List<int>();
            for (int i = 0; i < n; i++)
            {
                numbers[i] = byte.Parse(Console.ReadLine());
                for (int bitindex = 7; bitindex >= 0; bitindex--)
                {
                    int bit = numbers[i] >> bitindex;
                    bits.Add(bit & 1);
                }
               
            }
          
            for (int i = 0; i < bits.Count; i++)
            {
                if (i!=killbit)
                {
                    result = result << 1;
                    result = result | bits[i];
                    bitcounter++;
                }
                else
                {
                    killbit = killbit + step;
                    
                }
                if (bitcounter==8)
                {
                    Console.WriteLine(result);
                    bitcounter = 0;
                    result = 0;
                }
            }
            if (bitcounter>0)
            {
                int move = 8 - bitcounter;
                result = result << move;
                Console.WriteLine(result);
            }
        }
    }


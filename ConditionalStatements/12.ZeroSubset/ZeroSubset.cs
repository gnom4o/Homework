using System;

    class ZeroSubset
    {
        static void Main()
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e=int.Parse(Console.ReadLine());
            bool check = false;
           if(a+b==0)
           {
             Console.WriteLine("{0}+{1}=0",a,b);
             check = true;
           }
           if (a+c==0)
           {
               Console.WriteLine("{0}+{1}=0",a,c);
               check = true;
           }
            if(a+d==0)
            {
                Console.WriteLine("{0}+{1}=0",a,d);
                check = true;
            }
            if(a+e==0)
            {
                Console.WriteLine("{0}+{1}=0",a,e);
                check = true;
            }
            if(b+c==0)
            {
                Console.WriteLine("{0}+{1}=0",b,c);
            }
            if (b+d==0)
            {
                Console.WriteLine("{0}+{1}=0",b,d);
                check = true;
            }
            if (b+e==0)
            {
                Console.WriteLine("{0}+{1}=0",b,e);
                check = true;
            }
            if (c+d==0)
            {
                Console.WriteLine("{0}+{1}=0",c,d);
                check = true;
            }
            if (c+e==0)
            {
                Console.WriteLine("{0} + {1}=0",c,e);
                check = true;
            }
            if (d+e==0)
            {
                Console.WriteLine("{0} + {1}=0",d,e);
                check = true;
            }
            if (a+b+c==0)
	        {
                Console.WriteLine("{0} + {1} + {2}  =0", a, b, c);
                check = true;
	        }
            if (a+b+d==0)
	        {
                Console.WriteLine("{0} + {1} + {2}  =0", a, b, d);
                check = true;
	        }
            if (a+b+e==0)
	        {
                Console.WriteLine("{0} + {1} + {2}  =0", a, b, e);
                check = true;
	        }
            if (a+c+d==0)
	        {
                Console.WriteLine("{0} + {1} + {2}  =0", a, c, d);
                check = true;
	        }
            if (a+c+e==0)
	        {
                Console.WriteLine("{0} + {1} + {2}  =0", a, c, e);
                check = true;
	        }
            if (a+d+e==0)
	        {
                Console.WriteLine("{0} + {1} + {2}  =0", a, d, e);
                check = true;
	        }
            if (b+c+e==0)
	        {
                Console.WriteLine("{0} + {1} + {2}  =0", b, c, e);
                check = true;
	        }
            if(b+c+d==0)
            {
                Console.WriteLine("{0} + {1} + {2}  =0", b, c, d);
                check = true;
            }
            if (b+c+e==0)
	        {
                Console.WriteLine("{0} + {1} + {2}  =0", b, c, e); ;
                check = true;
	        }
            if (b+d+e==0)
            {
		        Console.WriteLine("{0} + {1} + {2}  =0",b,d,e);
                check = true;
	        }
            if (c+d+e==0)
	        {
                Console.WriteLine("{0} + {1} + {2} =0",c, d, e);
                check = true;
	        }
            if (a+b+c+d==0)
	        {
                Console.WriteLine("{0} + {1} + {2} + {3} =0", b, c, d, e);
                check = true;
	        }
            if (a+c+d+e==0)
	        {
                Console.WriteLine("{0} + {1} + {2} + {3} =0", b, c, d, e);
                check = true;
	        }
            if (b+c+d+e==0)
	        {
		        Console.WriteLine("{0} + {1} + {2} + {3} =0",b,c,d,e);
                check = true;
	        }
            if(a+b+c+d+e==0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} + {4}=0",a,b,c,d,e);
                check = true;
            }
            if (check==false)
            {
                Console.WriteLine("No Zero Subset");
            }


      }
    }

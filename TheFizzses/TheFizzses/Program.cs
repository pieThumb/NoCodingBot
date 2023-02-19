using System;

namespace TheFizzbuzz 
{ 
    class Program
    {
        public static void Main(string[] args) 
        {
            int index = 1;
            int num1 = 3;
            int num2  = 5;
            int num3 = 15;


            while (index < 31)
            {
               

                if (index % num3 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }

                else if (index % num1 == 0) 
                {
                    Console.WriteLine("fizz");
                }

                else if (index % num2 == 0)
                {
                    Console.WriteLine("buzz");
                }

                else
                {
                    Console.WriteLine(index);
                }

                


                index++;
            }

            Console.ReadKey();
        }
    }
}


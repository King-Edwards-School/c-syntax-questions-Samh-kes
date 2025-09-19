using System.ComponentModel.Design;

namespace Console_Blank_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question4();
        }
        public static void Question1() 
        {
            int Number = 0;
            int Count = 0;
            Console.Write("Enter an integer: ");
            int Number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another integer: ");
            int Number2 = Convert.ToInt32(Console.ReadLine());
            if (Number1 > Number2)
            {
                Number = Number1 / Number2;
            }
            else
            {
                Number = Number2 / Number1;
            }
            while(Count != Number)
            {
                Count ++;
                if (Count % 10 == 10)
                {
                    Console.Write("X");
                }
                else 
                {
                    if (Count % 10 == 0)
                    {
                        Console.Write("V");
                    }
                    else
                    {
                        Console.Write("/");
                    }
                }
            }
        }
        public static void Question2()
        {
            int Count = 0;
            bool multi;
            Console.WriteLine("Enter an integer greater than 1: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int x = 2;
            while (number > 1)
            {
                multi = false;
                while(number % x == 0)
                {
                    if (!multi)
                    {
                        Console.WriteLine(x);
                    }
                    Count++;
                    multi = true;
                    number = number / x;
                }
                x = x + 1;
            }
            Console.WriteLine(Count);
        }
        public static void Question3() 
        {
            Console.WriteLine("Enter an integer greater than 1: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int product = 1;
            int factor = 0;
            while (product < x)
            {
                factor++;
                product = product * factor;
            }
            if (x == product)
            {
                product = 1;
                for (int n = 1; n <= factor; n++)
                {
                    product = product * n;
                    Console.WriteLine(n);
                }
            }
            else
            {
                Console.WriteLine("No result");
            }
        }
        public static void Question4()
        {
            int count = 0;
            Console.WriteLine("Enter integer (0-99):");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Calculate additive or multiplicative persistence (a or m)?");
            string Operation = Console.ReadLine();
            while (value > 9)
            {
                if (Operation == "a")
                {
                    value = (value/10) + (value % 10);
                }
                else
                {
                    value = (value / 10) * (value % 10);
                }
                count++;
            }
            Console.WriteLine("The persistence is: ");
            Console.WriteLine(count);
        }

    }
}
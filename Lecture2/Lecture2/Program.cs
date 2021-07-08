using System;

namespace Lecture2
{
    class Program
    {
        static void Addition(int v1, int v2)
        {
            int result = v1 + v2;
            Console.WriteLine("{0} + {1} = {2}", v1, v2, result);
        }

        static void Subtraction(int v1, int v2)
        {
            int result = v1 - v2;
            Console.WriteLine("{0} - {1} = {2}", v1, v2, result);
        }

        static void Multipliation(int v1, int v2)
        {
            int result = v1 * v2;
            Console.WriteLine("{0} * {1} = {2}", v1, v2, result);
        }

        static void Division(int v1, int v2)
        {
            double result = (double)v1 / (double)v2;
            Console.WriteLine("{0} / {1} = {2}", v1, v2, result);
        }

        static void Calculator()
        {
            Console.WriteLine("Press any following key to perform an arithmetic operation:");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multipliation");
            Console.WriteLine("4 - Division");

            int op = Convert.ToInt32(Console.ReadLine());

            while (op > 4)
            {
                Console.WriteLine("Please Enter Number between 1-4");
                op = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter Value 1:");
            int v1 = int.Parse(Console.ReadLine());

            Console.Write("Enter Value 2:");
            int v2 = int.Parse(Console.ReadLine());

            if (op == 1) Addition(v1, v2);
            else if (op == 2) Subtraction(v1, v2);
            else if (op == 3) Multipliation(v1, v2);
            else Division(v1, v2);
            
            
        }

        static void Main(string[] args)
        {
            string con = "";

            do
            {
                Calculator();
                Console.WriteLine("Do you want to continue again(Y / N) ?");
                con = Console.ReadLine().ToUpper();

            } while (con != "N");

        }
    }
}
 
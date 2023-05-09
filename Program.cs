using System;

namespace Static_Members_Babcock_Olivia
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prints to the console
            Console.WriteLine("Integer Methods");
            // Adds, subtracts, etc x,y values and states result
            Console.WriteLine(Calculate.Add(100, 21));
            Console.WriteLine(Calculate.Sub(40, 9));
            Console.WriteLine(Calculate.Mult(10, 6));
            Console.WriteLine(Calculate.Div(20, 4));

            //Prints to the console
            Console.WriteLine("\nFloat Methods");
            // Adds, subtracts, etc x,y values and states result
            Console.WriteLine(Calculate.Add(100.44f, 21.11f));
            Console.WriteLine(Calculate.Sub(40.82f, 9.99f));
            Console.WriteLine(Calculate.Mult(10.05f, 6.73f));
            Console.WriteLine(Calculate.Div(20.67f, 4.36f));
        }
    }
}

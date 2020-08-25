using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ENTER A NUMBER: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("ENTER THE OPERATION: ");
            string operation = Console.ReadLine();

            Console.Write("ENTER A NUMBER: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            if (operation == "+")
            {
                Console.WriteLine(n1 + n2);
            }
            else if (operation == "-")
            {
                Console.WriteLine(n1 - n2);
            }
            else if (operation == "*")
            {
                Console.WriteLine(n1 * n2);
            }
            else if (operation == "/")
            {
                Console.WriteLine(n1 / n2);
            }
            else
            {
                Console.WriteLine("Invalid Operation");
            }



            Console.ReadLine();

        }
    }
}

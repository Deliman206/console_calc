using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome I am Computer and you are using Calculator.");
            Ops();
        }

        static decimal Ops()
        {
            decimal num1 = 0, num2 = 0;

            Console.WriteLine("What operation would you like to use?");
            Console.WriteLine("You can type Add, Subtract, Multiply, Divide");
            string answer = Console.ReadLine();

            Console.WriteLine("Your first number?");
            decimal.TryParse(Console.ReadLine(), out num1);

            Console.WriteLine("Your second number?");
            decimal.TryParse(Console.ReadLine(), out num2);

            switch (answer)
            {
                case "Add":
                    return Add(num1, num2);
                case "Subtract":
                    return Subtract(num1, num2);
                case "Multiply":
                    return Multiply(num1, num2);
                case "Divide":
                    return Divide(num1, num2);
                default:
                    return Ops();
            }
        }
        static decimal Add(decimal num1, decimal num2)
        {
            decimal solution = num1 + num2;
            Console.WriteLine($"The sum of {num1} & {num2} is {solution}");
            return Ops();
        }
        static decimal Subtract(decimal num1, decimal num2)
        {
            decimal solution = num1 - num2;
            Console.WriteLine($"The difference of {num1} & {num2} is {solution}");
            return Ops();
        }
        static decimal Multiply(decimal num1, decimal num2)
        {
            decimal solution = num1 * num2;
            Console.WriteLine($"The product of {num1} & {num2} is {solution}");
            return Ops();
        }
        static decimal Divide(decimal num1, decimal num2)
        {
            decimal solution = (decimal) num1 / num2;
            Console.WriteLine($"The division of {num1} & {num2} is {solution}");
            return Ops();
        }

    }
}

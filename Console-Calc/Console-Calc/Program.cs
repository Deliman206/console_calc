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

        static int Ops()
        {
            int num1 = 0, num2 = 0;

            Console.WriteLine("What operation would you like to use?");
            Console.WriteLine("You can type Add, Subtract, Multiply, Divide");
            string answer = Console.ReadLine();

            Console.WriteLine("Your first number?");
            Int32.TryParse(Console.ReadLine(), out num1);

            Console.WriteLine("Your second number?");
            Int32.TryParse(Console.ReadLine(), out num2);

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
        static int Add(int num1, int num2)
        {
            int solution = num1 + num2;
            Console.WriteLine($"The sum of {num1} & {num2} is {solution}");
            return Ops();
        }
        static int Subtract(int num1, int num2)
        {
            int solution = num1 - num2;
            Console.WriteLine($"The difference of {num1} & {num2} is {solution}");
            return Ops();
        }
        static int Multiply(int num1, int num2)
        {
            int solution = num1 * num2;
            Console.WriteLine($"The product of {num1} & {num2} is {solution}");
            return Ops();
        }
        static int Divide(int num1, int num2)
        {
            int solution = num1 / num2;
            Console.WriteLine($"The division of {num1} & {num2} is {solution}");
            return Ops();
        }

    }
}

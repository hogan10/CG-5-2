using System;

namespace CG_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask them to enter a number
            Console.WriteLine("Please enter a number: ");
            string numberOne = Console.ReadLine();
            double one = double.Parse(numberOne);

            //ask them to enter a second number
            Console.WriteLine("Please enter a second number: ");
            string numberTwo = Console.ReadLine();
            double two = double.Parse(numberTwo);


            //ask what they want to do with both numbers
            Console.WriteLine("Would you like to add, subtract, multiply, or divide? Please enter +, -, *, or /:");
            string userValue = Console.ReadLine();
            double total = 0;

            //if and else if statements to respond correctly to what the user inputs
            //within these statements we are also calling the individual methods for additon, subtraction, division and multiplication
             if (userValue == "+")
            {
                total = Add(one, two);
                Console.WriteLine($"{numberOne} + {numberTwo} = {total}");
            }

            else if (userValue == "-")
            {
                total = Subtract(one, two);
                Console.WriteLine($"{numberOne} - {numberTwo} = {total}");
            }

            else if (userValue == "/")
            {

                total = Divide(one, two);
                Console.WriteLine($"{numberOne} / {numberTwo} = {total}");
            }

            else if (userValue == "*")
            {
                total = Multiply(one, two);
                Console.WriteLine($"{numberOne} * {numberTwo} = {total}"); 
            }
            else
            {
                Console.WriteLine($"Sorry that is not valid.");
            }

            Console.WriteLine($"Your answer is: {total}");
            Console.ReadLine();
         
        }
        /// <summary>
        /// adding number one and two together
        /// </summary>
        /// <param name="numberOne"></param>
        /// <param name="numberTwo"></param>
        /// <returns>a solution to the addition of one and two</returns>
        private static double Add(double numberOne, double numberTwo)
        {
            double addition = numberOne + numberTwo;
            return addition;
        }

        /// <summary>
        /// subtract two from one
        /// </summary>
        /// <param name="numberOne"></param>
        /// <param name="numberTwo"></param>
        /// <returns>a solution to the subtraction of two from one</returns>
        private static double Subtract(double numberOne, double numberTwo)
        {
            double subtraction = numberOne - numberTwo;
            return subtraction;
        }
        /// <summary>
        /// dividing one by two
        /// </summary>
        /// <param name="numberOne"></param>
        /// <param name="numberTwo"></param>
        /// <returns>a solution to the divison of one by two</returns>
        private static double Divide(double numberOne, double numberTwo)
        {
            double division = numberOne / numberTwo;
            return division;
        }
        /// <summary>
        /// multiplying one and two together
        /// </summary>
        /// <param name="numberOne"></param>
        /// <param name="numberTwo"></param>
        /// <returns>solution for the multiplication of one and two</returns>
        private static double Multiply(double numberOne, double numberTwo)
        {
            double multiplication = numberOne * numberTwo;
            return multiplication;
        }
    }
}

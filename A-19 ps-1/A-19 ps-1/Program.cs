using System;


namespace A_19_ps_1
{
    internal class Program
    {
        public delegate int ArithmeticOperation(int num1, int num2);

       class program
        {
            static int Add(int num1, int num2)
            {
                return num1 + num2;
            }

            static int Subtract(int num1, int num2)
            {
                return num1 - num2;
            }

            static int Multiply(int num1, int num2)
            {
                return num1 * num2;
            }

            static int Divide(int num1, int num2)
            {
                return num1 / num2;
            }

            static void Main(string[] args)
            {
                ArithmeticOperation addition = Add;
                ArithmeticOperation subtraction = Subtract;
                ArithmeticOperation multiplication = Multiply;
                ArithmeticOperation division = Divide;

                Console.WriteLine("Enter two integers:");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Choose an arithmetic operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");

                int choice = int.Parse(Console.ReadLine());
                int result = 0;
                switch (choice)
                {
                    case 1:
                        result = addition(num1, num2);
                        Console.WriteLine("Result: " + result);
                        break;
                    case 2:
                        result = subtraction(num1, num2);
                        Console.WriteLine("Result: " + result);
                        break;
                    case 3:
                        result = multiplication(num1, num2);
                        Console.WriteLine("Result: " + result);
                        break;
                    case 4:
                        result = division(num1, num2);
                        Console.WriteLine("Result: " + result);
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

                Console.ReadLine();
            }
        }
    }
}


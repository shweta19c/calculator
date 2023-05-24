namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {


                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("Welcome to Calculator Program");
                Console.WriteLine("Enter first number: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an option from below: ");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");
                Console.WriteLine("\t% : Remainder");
                Console.Write("Enter an valid Option: ");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result of {num1} + {num2} is: " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result of {num1} - {num2} is: " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result of {num1} * {num2} is: " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your result of {num1} / {num2} is: " + result);
                        break;
                    case "%":
                        result = num1 % num2;
                        Console.WriteLine($"Your result of {num1} % {num2} is: " + result);
                        break;
                    default:
                        Console.WriteLine("That was not a valid option!");
                        break;
                }
                Console.WriteLine("Do you want to continue? (Y/N): ");
            } while (Console.ReadLine().ToUpper() == "Y");
            Console.WriteLine("Bye!!!");
            Console.ReadKey();
        }
    }
}
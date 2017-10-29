using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static private bool again = true;
       static void Main(string[] args)
        {

            while (again == true)
            {
                Console.WriteLine("Do you want to add, subtact, multiply, or divide?");
                string answer = Console.ReadLine();
                Console.WriteLine("What is your first number?");
                int first = Int32.Parse(Console.ReadLine());
                Console.WriteLine("What is your second number?");
                int second = Int32.Parse(Console.ReadLine());
                switch (answer)
                {
                    case "add":
                        add(first, second);
                        break;
                    case "subtract":
                        subtract(first, second);
                        break;
                    case "divide":
                        divide(first, second);
                        break;
                    case "multiply":
                        multiply(first, second);
                        break;
                    default:
                        Console.WriteLine("That is not a correct operation :/");
                        Console.ReadLine();
                        break;
                        
                }
                Console.WriteLine("Would you like to go again?");
                string askAgain = Console.ReadLine();
                againMethod(askAgain);
                
            }
        }
        public static void add(int num1, int num2)
        {
            Console.WriteLine("Your final number is " + (num1 + num2));
        }
        public static void subtract(int num1, int num2)
        {
            Console.WriteLine("Your final number is " + (num1 - num2));
        }
        public static void multiply(int num1, int num2)
        {
            Console.WriteLine("Your final number is " + (num1 * num2));
        }
        public static void divide(int num1, int num2)
        {
            if(num1%num2 != 0)
            {
                Console.WriteLine("Your final number is " + (num1 / num2) + " with a remainder of " + (num1 % num2));
            }else
            {
                Console.WriteLine("Your final number is " + (num1 / num2));
            }
        }
        public static void againMethod(string str1) //creates a loop if true 
        {
            
            if(str1 == "yes")
            {
                again = true;
            }else
            {
                again = false;
            }
        }
    }
}

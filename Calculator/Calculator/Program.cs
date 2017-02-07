using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            while(loop == true){
                Console.WriteLine("Would you like to add, subtract, multiply, or divide?");
                string operation = Console.ReadLine();
                Console.WriteLine("What is your first number?");
                int first = Int32.Parse(Console.ReadLine());
                Console.WriteLine("What is your second number?");
                int second = Int32.Parse(Console.ReadLine());
                if (operation == "add" || operation == "+")
                {
                    int final = first + second;
                    Console.WriteLine("Your final number is " + final + ". Would you like to go again?");
                    string ifloop = Console.ReadLine();
                    if(ifloop == "yes")
                    {
                        loop = true;
                    }else
                    {
                        loop = false;
                    }

                }else if(operation == "subtract" || operation == "-")
                {
                    int final = first - second;
                    Console.WriteLine("Your final number is " + final + ". Would you like to go again?");
                    string ifloop = Console.ReadLine();
                    if (ifloop == "yes")
                    {
                        loop = true;
                    }else
                    {
                        loop = false;
                    }
                }else if(operation == "multiply" || operation == "*")
                {
                    int final = first * second;
                    Console.WriteLine("Your final number is " + final + ". Would you like to go again?");
                    string ifloop = Console.ReadLine();
                    if(ifloop == "Yes")
                    {
                        loop = true;
                    }else
                    {
                        loop = false;
                    }
                }else if(operation == "divide" || operation == "/")
                {
                    int final = first / second;

                    if(first%second == 0)
                    {
                        Console.WriteLine("Your final number is " + final + ". Would you like to go again?");
                    }else
                    {
                        Console.WriteLine("Your final number is " + final + ", with a remainder of " + (first % second) + ". Would you like to go again?");
                    }
                    string ifloop = Console.ReadLine();
                    if(ifloop == "yes")
                    {
                        loop = true;
                    }else
                    {
                        loop = false;
                    }
                }
            }
        }
    }
}

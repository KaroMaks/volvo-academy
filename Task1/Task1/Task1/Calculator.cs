using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Calculator
    {
        
        static void Main()
        {
            string op_sign = "";
            double n1, n2;
            int value;
            ulong factorial;
            string sth = "+-*/^!";

            Console.Write("Enter sign of the operation you want to perform (+,-,*,/,^,!) or 0 to stop the process: ");
            op_sign = Console.ReadLine();

            do
            {
                switch (op_sign)
                {
                    case "+":
                        Console.Write("Enter the first number: ");
                        while(!double.TryParse(Console.ReadLine(), out n1)){
                            Console.Write("Enter the correct first number: ");
                        }
                        Console.Write("Enter the second number: ");
                        while(!double.TryParse(Console.ReadLine(), out n2)){
                            Console.Write("Enter the correct second number: ");
                        }
                        Console.WriteLine($"{n1} + {n2} = {n1+n2}");
                        op_sign = "";
                        break;
                    case "-":
                        Console.Write("Enter the first number: ");
                        while (!double.TryParse(Console.ReadLine(), out n1))
                        {
                            Console.Write("Enter the correct first number: ");
                        }
                        Console.Write("Enter the second number: ");
                        while (!double.TryParse(Console.ReadLine(), out n2))
                        {
                            Console.Write("Enter the correct second number: ");
                        }
                        Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
                        op_sign = "";
                        break;
                    case "*":
                        Console.Write("Enter the first number: ");
                        while (!double.TryParse(Console.ReadLine(), out n1))
                        {
                            Console.Write("Enter the correct first number: ");
                        }
                        Console.Write("Enter the second number: ");
                        while (!double.TryParse(Console.ReadLine(), out n2))
                        {
                            Console.Write("Enter the correct second number: ");
                        }
                        Console.WriteLine($"{n1} * {n2} = {n1 * n2}");
                        op_sign = "";
                        break;
                    case "/":
                        Console.Write("Enter the first number: ");
                        while (!double.TryParse(Console.ReadLine(), out n1))
                        {
                            Console.Write("Enter the correct first number: ");
                        }
                        Console.Write("Enter the second number: ");
                        while (!double.TryParse(Console.ReadLine(), out n2)|| n2 == 0)
                        {
                            Console.Write("Enter the correct second number: ");
                        }
                        Console.WriteLine($"{n1} / {n2} = {n1 / n2}");
                        op_sign = "";
                        break;
                    case "^":
                        Console.Write("Enter the first number: ");
                        while (!double.TryParse(Console.ReadLine(), out n1))
                        {
                            Console.Write("Enter the correct first number: ");
                        }
                        Console.Write("Enter the second number: ");
                        while (!double.TryParse(Console.ReadLine(), out n2))
                        {
                            Console.Write("Enter the correct second number: ");
                        }
                        Console.WriteLine($"{n1}^{n2} = {Math.Pow(n1,n2)}");
                        op_sign = "";
                        break;
                    case "!":
                        Console.Write("Enter the number: ");
                        while (!int.TryParse(Console.ReadLine(), out value) || value < 0 || value > 65)
                        {
                            Console.Write("Enter the correct number: ");
                        }
                        factorial = 1;
                        if(value != 0 || value != 1)
                        {
                            for(int i = 1; i <= value; i++)
                            {
                                factorial *= (ulong)i;
                            }
                        }
                        else
                        {
                            factorial = 1;
                        }
                        Console.WriteLine($"{value}! = {factorial}");
                        op_sign = "";
                        break;
                    default: 
                        Console.Write("Enter the sign of the operation you want to perform (+,-,*,/,^,!) or 0 to stop the process: ");
                        op_sign = Console.ReadLine();
                        break;
                }
            } while (op_sign != "0");
            
        }
    }
}

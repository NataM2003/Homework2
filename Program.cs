using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------- Task 1 -------------------------------");

            float num1, num2, num3;

            Console.WriteLine("Enter three numbers: " + "\n");

            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Number 1 = " + num1 + "\n");

            num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Number 2 = " + num2 + "\n");

            num3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Number 3 = " + num3 + "\n");

            //Перший варіант виконання завдання.

            if ((num1 >= -5) && (num1 <= 5))
            {
                Console.WriteLine("number 1 are in the range. ");
            }
            else
            {
                Console.WriteLine("number 1 aren't in the range. ");
            }

            if ((num2 >= -5) && (num2 <= 5))
            {
                Console.WriteLine("number 2 are in the range. ");
            }
            else
            {
                Console.WriteLine("number 2 aren't in the range. ");
            }

            if ((num3 >= -5) && (num3 <= 5))
            {
                Console.WriteLine("number 3 are in the range. ");
            }
            else
            {
                Console.WriteLine("number 3 aren't in the range. ");
            }

            //Другий варіант.

            Console.WriteLine((num1 >= -5) && (num1 <= 5) && (num2 >= -5) && (num2 <= 5) && (num3 >= -5) && (num3 <= 5) ? "Numbers are all in the range [-5; 5]." : "Numbers aren't all in the range [-5; 5].");


            Console.WriteLine("------------------------------- Task 2 -------------------------------");

            int a, b, c;

            Console.WriteLine("Enter first number: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter third number: ");
            c = int.Parse(Console.ReadLine());

            if ((a > b) && (a > c))
            {
                Console.WriteLine("Max number: " + a + "\n");
                if (b > c)
                {
                    Console.WriteLine("Min number: " + c + "\n");
                }
                else
                {
                    Console.WriteLine("Min number: " + b + "\n");
                }
            }

            else if ((b > a) && (b > c))
            {
                Console.WriteLine("Max number: " + b + "\n");
                if (a > c)
                {
                    Console.WriteLine("Min number: " + c + "\n");
                }
                else
                {
                    Console.WriteLine("Min number: " + a + "\n");
                }
            }

            else if ((c > a) && (c > b))
            {
                Console.WriteLine("Max number: " + c + "\n");
                if (a > b)
                {
                    Console.WriteLine("Min number: " + b + "\n");
                }
                else
                {
                    Console.WriteLine("Min number: " + a + "\n");
                }
            }

            Console.WriteLine("------------------------------- Task 3 -------------------------------");

            Console.WriteLine("Enter error and number: ");

            string str = Console.ReadLine();
            HTTPError error = (HTTPError)Enum.Parse(typeof(HTTPError), str, ignoreCase: true);

            switch (error)
            {
                case HTTPError.Error400:
                    Console.WriteLine("Bad Request.");
                    break;
                case HTTPError.Error401:
                    Console.WriteLine("Unauthorized.");
                    break;
                case HTTPError.Error402:
                    Console.WriteLine("Payment Required.");
                    break;
                case HTTPError.Error403:
                    Console.WriteLine("Forbidden.");
                    break;
                case HTTPError.Error404:
                    Console.WriteLine("Not Found.");
                    break;
                case HTTPError.Error405:
                    Console.WriteLine("Method Not Allowed.");
                    break;
                case HTTPError.Error406:
                    Console.WriteLine("Not Acceptable.");
                    break;
                default:
                    break;
            }

            Console.WriteLine("------------------------------- Task 4 -------------------------------");

            Dog myDog;
            myDog.name = "Petro";
            myDog.mark = "chihuahua";
            myDog.age = 11;

            myDog.Info();

            Console.ReadKey();
        }
        struct Dog
        {
            public string name;
            public string mark;
            public int age;

            public void Info()
            {
                Console.WriteLine($"Dog name '{name}', mark {mark}, age of the dog {age}.");
            }
        }
    }
}

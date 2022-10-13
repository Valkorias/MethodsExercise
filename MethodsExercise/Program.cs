using System;

namespace MethodsExercise
{
    internal class Program
    {
        private static int sum;

        static void Main(string[] args)
        {
             Console.WriteLine("what is your name?");
             string username = Console.ReadLine();


             Console.WriteLine("how old are you?");
             string age = Console.ReadLine();

             Console.WriteLine("what is a name for an dog?");
             string userdogname = Console.ReadLine();

            Console.WriteLine("what color is your dog?");
            string userdogcolor = Console.ReadLine();

            Console.WriteLine($"there was a wanderer named {username}, he was {age} years old.");
            Console.WriteLine($"he had a fearsome {userdogcolor} dog named {userdogname}");
            Console.WriteLine($"{username} loved {userdogname} but being {age} years old sure made life difficult!");

            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first number");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num1, 2, 3, 5, 7);
            Console.WriteLine($"The sum is: {sum}");

            Console.WriteLine("Give me a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply the first number with");
            num2 = int.Parse(Console.ReadLine());

            int product = Sum(num1, num1);
            Console.WriteLine($"The product is: {product}");
        }

        public static int Sum(params int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];
            }

            return sum;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
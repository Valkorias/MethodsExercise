namespace MethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();


            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();

            Console.WriteLine("What is a name for an dog?");
            string userDogName = Console.ReadLine();

            Console.WriteLine("What color is your dog?");
            string userDogColor = Console.ReadLine();

            Console.WriteLine($"There was a man named {userName}, He was {age} years old.");
            Console.WriteLine($"He had a {userDogColor} dog named {userDogName}");
            Console.WriteLine($"{userName} loved {userDogName} but he did not love being {age} years old!");
        }
    }
}
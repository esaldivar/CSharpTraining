// See https://aka.ms/new-console-template for more information

namespace HelloWorld
{
    class Program
    {
        //Entry point of our program
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string name = Console.ReadLine()!;
            Console.WriteLine($"Hello {name}");

        }
    }
}
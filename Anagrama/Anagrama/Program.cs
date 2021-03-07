using System;

namespace Anagrama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your line please: ");
            var input = Console.ReadLine();
            var anagrama = new Anagram();
            try
            {
                Console.WriteLine($"Your line is: {anagrama.GetOutput(input)}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}

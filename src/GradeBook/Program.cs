using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello! " + args[0] + "!");
            if (args.Length > 0)
            {
                // Using string interpolation
                Console.WriteLine($"Hello! , {args[0]}!");
            }
            else
            {
                Console.WriteLine("You have not passed the arguments");
            }
          
        }
    }
}

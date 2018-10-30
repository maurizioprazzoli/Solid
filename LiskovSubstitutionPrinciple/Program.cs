using System;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectange = new Rectangle();
            rectange.SetLength(4);
            rectange.SetWidth(5);

            Console.WriteLine($"Rectangle area is {rectange.Area()}");

            /*
             * 
             * LSP Violation
             * 
             */

            var square = new Square();
            square.SetLength(4);
            square.SetWidth(5);
            Console.WriteLine($"Rectangle area is {square.Area()}");


            Console.ReadKey();
        }
    }
}

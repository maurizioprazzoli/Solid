using System;

namespace InterfaceSegregationPrinciple.Refactoring
{
    class Penguin : IBird
    {
        public void Walk()
        {
            Console.WriteLine("Do Penguin Walk");
        }
    }
}

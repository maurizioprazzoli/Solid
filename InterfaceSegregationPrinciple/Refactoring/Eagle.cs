using System;

namespace InterfaceSegregationPrinciple.Refactoring
{
    class Eagle : IBird, IFlyingBird
    {
        public void Fly()
        {
            Console.WriteLine("Do Fly");
        }

        public void Walk()
        {
            Console.WriteLine("Do Walk");
        }
    }
}

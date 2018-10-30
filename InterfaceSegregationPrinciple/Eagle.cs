using System;

namespace InterfaceSegregationPrinciple
{
    class Eagle : IBird
    {
        public void Fly()
        {
            Console.WriteLine("Do Eagle Fly");
        }

        public void Walk()
        {
            Console.WriteLine("Do Eagle Walk");
        }
    }
}

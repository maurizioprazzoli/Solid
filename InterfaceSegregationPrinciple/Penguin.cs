
using System;

namespace InterfaceSegregationPrinciple
{
    class Penguin : IBird
    {
        public void Fly()
        {
            throw new NotSupportedException("Penguin can not fly");
        }

        public void Walk()
        {
            Console.WriteLine("Do Penguin Walk");
        }
    }
}

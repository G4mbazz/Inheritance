using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal test = new Animal("jeff", 12, "Yes please", false, 69);
            test.AnimalInfo();
            test.Run();
        }
    }
}

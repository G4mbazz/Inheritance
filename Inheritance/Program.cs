using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int horseSpeed = r.Next(45, 70);
            Animal test = new Animal("jeff", 12, "Yes please", false, 69);
            Snek noStepOn = new Snek("Snek", 15, "Hane", false, 7, true);
            Horse enjoyer = new Horse("Honse", 8, "Hane", true, 90, horseSpeed);
            test.AnimalInfo();
            test.Run();
            test.MakeSound();
            Console.WriteLine();
            noStepOn.AnimalInfo();
            noStepOn.Run();
            noStepOn.MakeSound();
            noStepOn.DoTCheck();


            


        }
    }
}

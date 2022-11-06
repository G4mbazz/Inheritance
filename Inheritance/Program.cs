using System;

namespace Inheritance
{
    //Sebastian SUT22
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int horseSpeed = r.Next(45, 70);
            int goldFind = r.Next(51);
            Snek noStepOn = new Snek("Snek", 15, "Hane", false, 7, true);
            Horse enjoyer = new Horse("Honse", 8, "Hane", true, 90, horseSpeed);
            Doge goodBoy = new Doge("Gizmo", 5, "Hane", true, 25, false);
            Golden retriever = new Golden("Karin", 12, "Hona", true, 30, false, goldFind);
            Chihuahua dog = new Chihuahua("Sara", 7, "Hona", false, 2, false, true);

            noStepOn.AnimalInfo();
            noStepOn.MakeSound();
            noStepOn.DoTCheck();

            Console.WriteLine("\n~~~~~~~~~~Nästa Djur~~~~~~~~~~\n");

            enjoyer.AnimalInfo();
            enjoyer.MakeSound();
            enjoyer.Speed();

            Console.WriteLine("\n~~~~~~~~~~Nästa Djur~~~~~~~~~~\n");

            goodBoy.AnimalInfo();
            goodBoy.MakeSound();
            goodBoy.Allergy();

            Console.WriteLine("\n~~~~~~~~~~Nästa Djur~~~~~~~~~~\n");

            retriever.AnimalInfo();
            retriever.MakeSound();
            retriever.RetriveGold();

            Console.WriteLine("\n~~~~~~~~~~Nästa Djur~~~~~~~~~~\n");

            dog.AnimalInfo();
            dog.MakeSound();
            dog.Rage();

            Console.ReadKey();
        }
    }
}

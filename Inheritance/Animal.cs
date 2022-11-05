using System;

namespace Inheritance
{
    public class Animal
    {
        public readonly string Name = "";
        private readonly int Age = 0;
        private readonly string Gender = "";
        private readonly bool Legs = false;
        private readonly int Weight = 0;

        public Animal()
        {

        }
        public Animal(string _name, int _age, string _gender, bool _legs, int _weight)
        {
            Legs = _legs;
            Name = _name;
            Age = _age;
            Gender = _gender;
            Weight = _weight;
        }
        public void AnimalInfo()
        {
            Console.WriteLine($"Namn: {Name}\nÅlder: {Age}År\nKön: {Gender}\nVikt: {Weight}Kg");
            if (Legs) Console.WriteLine("Djuret har ben");
            else Console.WriteLine("Djuret har inga ben");
        }
        public void Run()
        {
            if (!Legs) Console.WriteLine("Ditt djur har inga ben och kan därför inte gå eller springa");
            else Console.WriteLine("Ditt djur kan springa!");
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("Suh dude");
        }
    }
}

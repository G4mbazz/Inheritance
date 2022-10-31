using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Animal
    {
        private readonly string Name;
        private readonly int Age;
        private readonly string Gender;
        private readonly bool Legs;
        private readonly int Weight;
        
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
            Console.WriteLine($"Namn: {Name}\nÅlder: {Age}\nKön: {Gender}\nVikt: {Weight}");
            if (Legs) Console.WriteLine("Djuret har ben");
            else Console.WriteLine("Djuret har inga ben");
        }
        public void Run()
        {
            if (!Legs)
            {
                Console.WriteLine("Ditt djur har inga ben och kan därför inte gå eller springa");
            }
            else
            {
                Console.WriteLine("Ditt djur kan springa!");
            }
        }
    }
}

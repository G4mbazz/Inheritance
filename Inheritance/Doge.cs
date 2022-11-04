using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Doge : Animal
    {
        private readonly bool AllergyFriendly;
        public Doge(string _name, int _age, string _gender, bool _legs, int _weight, bool _allergyFriendly) : base(_name, _age, _gender, _legs, _weight)
        {
            AllergyFriendly = _allergyFriendly;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Hund säger: Woof");
        }
        public void Allergy()
        {
            if (AllergyFriendly) Console.WriteLine("Hunden är allergivänlig");
            else Console.WriteLine("Hunden är inte allergivänlig");
        }

    }
}

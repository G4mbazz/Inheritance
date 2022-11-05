using System;

namespace Inheritance
{
    public class Snek : Animal
    {
        private readonly bool IsVenomous = true;
        public Snek() : base()
        {

        }
        public Snek(string _name, int _age, string _gender, bool _legs, int _weight, bool _isVenomous) : base(_name, _age, _gender, _legs, _weight)
        {
            IsVenomous = _isVenomous;
        }
        public void DoTCheck()
        {
            if (IsVenomous) Console.WriteLine("Ormen kan inte springa men du borde");
            else Console.WriteLine("Du kan klappa orm utan problem");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Ormen säger: Im a sssssssnake");
        }
    }
}

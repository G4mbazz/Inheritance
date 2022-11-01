using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Horse : Animal
    {
        private readonly int TopSpeed;
        public Horse(string _name, int _age, string _gender, bool _legs, int _weight, int _topSpeed) : base(_name, _age, _gender, _legs, _weight)
        {
            TopSpeed = _topSpeed;
        }
        public void Speed()
        {
            if (TopSpeed <= 50) Console.WriteLine("Din häst är tyvärr en av de långsammare hästarna med maxhastighet {0}km/h", TopSpeed);
            else if (TopSpeed > 50 && TopSpeed < 55)Console.WriteLine("Din häst ");
        }
        public override void MakeSound()
        {
            Console.WriteLine("Häst säger: Bäää"); ;
        }
    }
}

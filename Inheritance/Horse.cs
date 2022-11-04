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
            else if (TopSpeed > 50 && TopSpeed < 55)Console.WriteLine("Denna hästens maxhastighet är {0}Km/h vilket är medelhastigheten för hästar", TopSpeed);
            else if (TopSpeed > 55 && TopSpeed < 60) Console.WriteLine("En av dom snabbaste hästarna i världen asså {0}Km/h",TopSpeed);
            else Console.WriteLine("Nytt världsrekord asså {0}Km/h!", TopSpeed);
        }
        public override void MakeSound()
        {
            Console.WriteLine("Häst säger: Bäää"); ;
        }
    }
}

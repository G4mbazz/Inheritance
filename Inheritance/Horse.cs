using System;

namespace Inheritance
{
    public class Horse : Animal
    {
        private readonly int TopSpeed = 0;
        public Horse() : base()
        {

        }
        public Horse(string _name, int _age, string _gender, bool _legs, int _weight, int _topSpeed) : base(_name, _age, _gender, _legs, _weight)
        {
            TopSpeed = _topSpeed;
        }
        //Prints the speed of the horse
        public void Speed()
        {
            if (TopSpeed <= 50) Console.WriteLine("Din häst är tyvärr en av de långsammare hästarna med maxhastighet {0}Km/h", TopSpeed);
            else if (TopSpeed > 50 && TopSpeed < 55)Console.WriteLine("Denna hästens maxhastighet är {0}Km/h vilket är medelhastigheten för hästar", TopSpeed);
            else if (TopSpeed > 55 && TopSpeed < 60) Console.WriteLine("Snabbare än de flesta hästarna men fortfarande inte världsklass på {0}Km/h", TopSpeed);
            else Console.WriteLine("En av dom snabbaste hästarna i världen asså {0}Km/h!", TopSpeed);
        }
        public override void MakeSound()
        {
            Console.WriteLine("Hästen Gnäggar"); 
        }
    }
}

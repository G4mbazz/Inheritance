using System;

namespace Inheritance
{
    public class Golden:Doge
    {

        private readonly int Retrieve = 0;
        public Golden() : base()
        {

        }
        public Golden(string _name, int _age, string _gender, bool _legs, int _weight, bool _allergyFriendly, int _retrieve) : base(_name, _age, _gender, _legs, _weight, _allergyFriendly)
        {
            Retrieve = _retrieve;
        }
        //Prints if the dog is able to find gold or not
        public void RetriveGold()
        {
            if (Retrieve >= 50) Console.WriteLine("Golden retrievern lyckades på något sätt hitta guld");
            else Console.WriteLine("Klart att hunden inte kan hämta guld, vad förväntade du dig?");
        }
    }
}

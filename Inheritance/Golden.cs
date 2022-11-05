using System;

namespace Inheritance
{
    public class Golden:Doge
    {

        private readonly bool Retrieve = false;
        public Golden() : base()
        {

        }
        public Golden(string _name, int _age, string _gender, bool _legs, int _weight, bool _allergyFriendly, bool _retrieve) : base(_name, _age, _gender, _legs, _weight, _allergyFriendly)
        {
            Retrieve = _retrieve;
        }

        public void RetriveGold()
        {
            if (Retrieve) Console.WriteLine("Golden retrievern lyckades på något sätt hitta guld");
            else Console.WriteLine("Klart att hunden inte kan hämta guld, vad förväntade du dig?");
        }
    }
}

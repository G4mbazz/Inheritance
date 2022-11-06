using System;

namespace Inheritance
{
    public class Chihuahua : Doge
    {
        private readonly bool IsAmgery = true;
        public Chihuahua()
        {

        }
        public Chihuahua(string _name, int _age, string _gender, bool _legs, int _weight, bool _allergyFriendly, bool _isAmgery) : base(_name, _age, _gender, _legs, _weight, _allergyFriendly)
        {
            IsAmgery = _isAmgery;
        }
        //prints that the dog is angery
        public void Rage()
        {
            if (IsAmgery) Console.WriteLine("Chihuahuan skakar av ilska");
            else Console.WriteLine("Men det var en lögn, Chihuahuan är alltid arg");
        }

    }
}

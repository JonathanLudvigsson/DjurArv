using System;
using System.Collections.Generic;
using System.Text;

namespace DjurArv
{
    internal class Dog : Animal
    {
        public string FurColor { get; set; }
        public Dog(string species = "Dog", int legs = 4, int eyes = 2, int tails = 1, bool hasFeathers = false, bool isMammal = true, string furColor = "Brown")
            : base(species, legs, eyes, tails, hasFeathers, isMammal)
        {
            FurColor = furColor;
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("Woof");
        }
        public void WagTail()
        {
            Console.WriteLine($"{Species} is wagging its tail");
        }
    }
}

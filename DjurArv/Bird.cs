using System;
using System.Collections.Generic;
using System.Text;

namespace DjurArv
{
    internal class Bird : Animal
    {
        public bool CanFly { get; set; }
        public Bird(string species = "Bird", int legs = 2, int eyes = 2, int tails = 1, bool hasFeathers = true, bool isMammal = false, bool canFly = true) 
            : base(species, legs, eyes, tails, hasFeathers, isMammal)
        {
            CanFly = canFly;
        }
        public void MakeSound()
        {
            Console.WriteLine("Caw caw caw");
        }
        public void Fly()
        {
            Console.WriteLine($"{Species} is flying!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DjurArv
{
    internal class Cat : Animal
    {
        public int Lives { get; set; }
        public Cat(string species = "Cat", int legs = 4, int eyes = 2, int tails = 1, bool hasFeathers = false, bool isMammal = true, int lives = 9)
            : base(species, legs, eyes, tails, hasFeathers, isMammal)
        {
            Lives = lives;
        }
        public void MakeSound()
        {
            Console.WriteLine("Meow");
        }
        public void Hiss()
        {
            Console.WriteLine($"{Species} is hissing");
        }
    }
}

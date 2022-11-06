using System;

namespace DjurArv
{
    internal class Animal
    {
        public string Species { get; set; }
        public int Legs { get; set; }
        public int Eyes { get; set; }
        public int Tails { get; set; }
        public bool HasFeathers { get; set; }
        public bool IsMammal { get; set; }
        public Animal(string species = "Unknown", int legs = 0, int eyes = 0, int tails = 0, bool hasFeathers = false, bool isMammal = false)
        {
            Species = species;
            Legs = legs;
            Eyes = eyes;
            Tails = tails;
            HasFeathers = hasFeathers;
            IsMammal = isMammal;
        }
        public void Walk()
        {
            Console.WriteLine($"{Species} is walking...");
        }
        public void Jump()
        {
            Console.WriteLine($"{Species} just jumped!");
        }
        public void Eat()
        {
            Console.WriteLine($"{Species} is eating, nom nom nom");
        }
    }
}

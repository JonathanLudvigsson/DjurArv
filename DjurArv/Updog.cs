using System;
using System.Collections.Generic;
using System.Text;

namespace DjurArv
{
    internal class Updog : Dog
    {
        public string UpDog { get; set; }
        public Updog(string species = "Updog", int legs = 4, int eyes = 2, int tails = 1, bool hasFeathers = false, bool isMammal = true, string furColor = "Brown", string upDog = "Not much how bout you?")
            : base(species, legs, eyes, tails, hasFeathers, isMammal, furColor)
        {
            UpDog = upDog;
        }
        public void WhatsUp()
        {
            Console.WriteLine($"{Species} is asking what's up dog?");
        }
        public override void MakeSound()
        {
            Console.WriteLine("Updog woof");
        }
    }
}

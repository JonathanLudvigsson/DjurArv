using System;
using System.Collections.Generic;
using System.Text;

namespace DjurArv
{
    internal class GoldenRetriever : Dog
    {
        public bool WillRetrieve { get; set; }
        public GoldenRetriever(string species = "Golden Retriever", int legs = 4, int eyes = 2, int tails = 1, bool hasFeathers = false, bool isMammal = true, string furColor = "Gold", bool willRetrieve = true)
            : base(species, legs, eyes, tails, hasFeathers, isMammal, furColor)
        {
            WillRetrieve = willRetrieve;
        }
        public void ChaseBall()
        {
            Console.WriteLine($"{Species} is chasing a ball");
        }
        public override void MakeSound()
        {
            Console.WriteLine("Golden woof");
        }
    }
}

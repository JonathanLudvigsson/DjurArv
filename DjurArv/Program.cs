using System;

namespace DjurArv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird();
            bird.MakeSound();

            Cat cat = new Cat();
            cat.MakeSound();

            Dog dog = new Dog();
            dog.MakeSound();

            GoldenRetriever goldenRetriever = new GoldenRetriever();
            goldenRetriever.MakeSound();

            Updog updog = new Updog();
            updog.MakeSound();
        }
    }
}

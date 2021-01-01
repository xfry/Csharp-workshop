using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Actor Human = new Actor();
            Human.Strength = 40;

            Console.WriteLine("Hello World! {0}", Human.Strength);
            Console.WriteLine("Runnin speed: {0}", Human.Run());
            Console.WriteLine("move: {0}", Human.Constitution);
            System.Console.WriteLine("Is Human?: {0}", Human.CheckClass(ActorType.Elfo));
        }
    }
}

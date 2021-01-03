using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //You can start instantiating the type
            Vec2 Vec = new Vec2(100,200);
            Vec2 VecCopy = Vec;
            
            //As you can see this changes will be made by Value.
            VecCopy.Y = 500;
            Console.WriteLine($"Vec: {Vec}");
            Console.WriteLine($"VecCopy: {VecCopy}");
            Console.WriteLine($"Vec: after modified VecCopy: {Vec}");
            ChangeAndDisplay(VecCopy);
            Console.WriteLine($"VecCopy: after calling Change: {VecCopy}");
        }

        public static void ChangeAndDisplay (Vec2 Vec)
        {
            Vec.X = 300;
            Console.WriteLine($"copy of VecCopy: {Vec}");
        }
    }
}

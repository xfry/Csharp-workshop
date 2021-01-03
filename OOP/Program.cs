using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            Object b = a;   //boxing al valor de a
            a = (int)b;     //unboxing al valor.

            //Usamos el value type Vec2, y le hacemos Boxing (Lea Struct.cs para entender.)
            Vec2 Vec = new Vec2(100,200);
            Vec2 VecCopy = Vec;
            
            //Demostrando por que las Structs son Value Type
            VecCopy.Y = 500;
            Console.WriteLine($"Vec: {Vec}");
            Console.WriteLine($"VecCopy: {VecCopy}");
            Console.WriteLine($"Vec: after modified VecCopy: {Vec}");
            ChangeAndDisplay(VecCopy);
            Console.WriteLine($"VecCopy: after calling Change: {VecCopy}");
        }

        //Metodo que recibe un Structura por valor.
        public static void ChangeAndDisplay (Vec2 Vec)
        {
            Vec.X = 300;
            Console.WriteLine($"copy of VecCopy: {Vec}");
        }
    }
}

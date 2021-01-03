/*
 * Structs works by Value not by reference. so lets see a example in Program.cs file
*/
using System;

namespace OOP
{
    public struct Vec2
    {
        public int X;
        public int Y;

        public Vec2(int x, int y) => (X, Y) = (x,y);

        public override string ToString() => $"({X}, {Y})";
    }
}
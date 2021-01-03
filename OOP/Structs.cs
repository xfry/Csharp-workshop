/*
 * Las Structs funcionan por valor.
 * Cuando una struct value type es instanciado de un typo por referencia, esta pasa por el proceso de
 * Boxing y un-Boxing.
 * Boxing es usado para guardar Value Types en el Heap y es la conversion implicita de un Value Type
 * a un Object.
*/
using System;

namespace OOP
{
    public struct Vec2
    {
        public int X;
        public int Y;

        //Una Struct puede tener constructor
        public Vec2(int x, int y) => (X, Y) = (x,y);
        
        //Puedes sobreescribir metodos existentes 
        public override string ToString() => $"({X}, {Y})";
    }
}
using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Fredy = new Person(25, "Fredy Enrique");
            Console.WriteLine("Peron Name: {0}", Fredy.Name);
            Console.WriteLine("Person Age: {0}", Fredy.Age);


            //Podemos inicializar las propiedades de una clase mediante le uso de Object Inicialization
            var Mom = new Person()
            {
                Age = 56
                //Name = "Yubenny", no puede ser usado aqui, porque el descriptor de la propiedad es private.
            };

            Mom.setName("Yubenny Andrade");
            Console.WriteLine("Peron Name: {0}", Mom.Name);
            Console.WriteLine("Person Age: {0}", Mom.Age);
        }
    }
}

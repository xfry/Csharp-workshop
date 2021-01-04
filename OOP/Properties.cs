using System;

namespace OOP
{
    public class Person
    {
        //Las propiedades nos permiten una mayor encapsulacion de los 
        public int Age {get; set;}
        public String Name {get; private set;}

        //constructor
        public Person() {}
        
        /* Sobre escribimos el constructor, ahora agregamos inicializacion a los parametros.
         * Haciendo opcional los valores para los mismos. 
        */ 
        public Person(int age = 0, String name = "")
        {
            this.Age = age;
            this.Name = name;
        }

        public void setName(String name)
        {
            this.Name = name;
        }

    }
}
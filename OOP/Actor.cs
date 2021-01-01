using System;

namespace OOP
{
    enum ActorType
    {
        Elfo,
        Dwarf,
        Goblin,
        Ork,
        Human,
        Beast
    }
    public class Actor
    {
        internal int Strength {get; set;}
        internal int Dexterity {get; set;}
        internal int Constitution {get; set;}
        internal int Wisdom {get; set;}
        internal int Charisma {get; set;}

        ActorType human = ActorType.Human;
        public Actor()
        {
            Strength = 0;
            Dexterity = 0;
            Constitution = 0;
            Wisdom = 0;
            Charisma = 0;
        }

        internal int Move()
        {
            return Strength+Constitution;
        }

        internal int Run()
        {
            return (Constitution+=1);
        }

        internal bool CheckClass (ActorType actorType)
        {
            return (this.human == actorType);
        }
    }
}
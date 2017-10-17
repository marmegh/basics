using System;

namespace human
{
    class Program
    {
        public class Human
        {
            public string name;
            public int strength;
            public int intelligence;
            public int dexterity;
            public int health;
            public Human(string myname = "Joe")
            {
                name = myname;
                strength = 3;
                intelligence = 3;
                dexterity = 3;
                health = 100;
            }
            public Human(string myname = "Joe", int mystrength = 3, int myint = 3, int mydex = 3, int myhealth = 100)
            {
                name = myname;
                strength = mystrength;
                intelligence = myint;
                dexterity = mydex;
                health = myhealth;
            }
            public void Attack(Human victim)
            {
                victim.health -= 5*strength;
            }
            public void Attack(object someone)
            {
                if (someone is Human)
                {
                    Human victim = someone as Human;
                    int damage = 5 * strength;
                    victim.health = victim.health - damage;
                }
            }
        }
        static void Main(string[] args)
        {
            Human first = new Human("Suzzie");
            Human second = new Human("Jill");
            first.Attack(second);
            System.Console.WriteLine(second.health);
            System.Console.WriteLine(first.health);

        }
    }
}

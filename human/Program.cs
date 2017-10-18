using System;
using System.Collections.Generic;

namespace human
{
    class Program
    {
        public static Random rand = new Random();
        public class Human
        {
            public string name;
            public int strength;
            public int intelligence;
            public int dexterity;
            public int health;            
            public Human(string myname = "Joe", int mystrength = 3, int myint = 3, int mydex = 3, int myhealth = 100)
            {
                this.name = myname;
                this.strength = mystrength;
                this.intelligence = myint;
                this.dexterity = mydex;
                this.health = myhealth;
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
                    if(victim == null){
                        System.Console.WriteLine("Failed Attack");
                    }
                    else{
                        victim.health -= 5*strength;
                    }
                }
            }
        }
        public class Wizard : Human
        {
            public Wizard(string myname, int mystrength, int myint, int mydex, int myhealth) : base(myname, mystrength, myint = 25, mydex, myhealth = 50){
                this.name = myname;
                this.strength = mystrength;
                this.intelligence = myint;
                this.dexterity = mydex;
                this.health = myhealth;
            }
            public void Heal(){
                this.health += intelligence * 10;
            }
            public void fireball(object obj){
                if (obj is Human){
                    Human victim = obj as Human;
                    if(victim == null){
                        System.Console.WriteLine("Failed Attack");
                        }
                    else{
                        int damage = rand.Next(20,50);
                        victim.health -= damage;
                    }
                }
            }
        }
        public class Ninja : Human
        {
            public Ninja(string myname, int mystrength, int myint, int mydex, int myhealth) : base(myname, mystrength, myint, mydex = 175, myhealth){
                this.name = myname;
                this.strength = mystrength;
                this.intelligence = myint;
                this.dexterity = mydex;
                this.health = myhealth;
            }
            public void Steal(object obj){
                health += 10;
                Attack(obj);
            }
            public void get_away(){
                health -= 15;
            }
        }
        public class Samurai : Human
        {
            public Samurai(string myname, int mystrength, int myint, int mydex, int myhealth) : base(myname, mystrength, myint, mydex, myhealth = 200){
                this.name = myname;
                this.strength = mystrength;
                this.intelligence = myint;
                this.dexterity = mydex;
                this.health = myhealth;
            }
            public void death_blow(object obj){
                if(obj is Human){
                    Human victim = obj as Human;
                    Attack(victim);
                    if(victim.health < 50){
                        victim.health = 0;
                    }
                }                
            }
            public void meditate(){
                this.health = 200;
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

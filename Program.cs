using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            human newHuman = new human("Adam");
            System.Console.WriteLine($"a new human has been added! They are named {newHuman.Name} and have Strength: {newHuman.Strength}, Intelligence: {newHuman.Intelligence}, Dexterity: {newHuman.Dexterity}, Health: {newHuman.health} ");
            human secondHuman = new human("Jim", 2, 2, 2, 50);
            System.Console.WriteLine($"a new human has been added! They are named {secondHuman.Name} and have Strength: {secondHuman.Strength}, Intelligence: {secondHuman.Intelligence}, Dexterity: {secondHuman.Dexterity}, Health: {secondHuman.health} ");
             newHuman.Attack(secondHuman);
             Ninja aNinja = new Ninja("NInjaman");
             System.Console.WriteLine($"a new Ninja has been added! They are named {aNinja.Name} and have Strength: {aNinja.Strength}, Intelligence: {aNinja.Intelligence}, Dexterity: {aNinja.Dexterity}, Health: {aNinja.health} ");
             Wizard aWizard = new Wizard("Gandolf");
             System.Console.WriteLine($"a new Wizard has been added! They are named {aWizard.Name} and have Strength: {aWizard.Strength}, Intelligence: {aWizard.Intelligence}, Dexterity: {aWizard.Dexterity}, Health: {aWizard.health} ");
             Console.WriteLine(aNinja.health);
             aWizard.Attack(aNinja);
             Console.WriteLine(aNinja.health);
        }
    }
    class human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int Health;
        public int health{
            get { return Health; }
            set {Health = value;}
        }
        public human(string theirName){
            Name = theirName;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;
        }
        public human(string theirName, int theirStren, int theirIntel, int theirDext, int theirHealth){
            Name =theirName;
            Strength = theirStren;
            Intelligence = theirIntel;
            Dexterity = theirDext;
            Health = theirHealth;
        }
        public int Attack(human target){
            int damageDone = this.Strength * 5;
            target.Health = target.Health-damageDone; 
            System.Console.WriteLine(Health);
            System.Console.WriteLine(target.Health);
            return target.Health;
        }
    }
    //end of class human
    //beginning of class ninja
    class Ninja : human
    {
        public Ninja(string theirName) : base(theirName)
        {
            Dexterity = 175;
        }
    }
    class Wizard : human
    {
        public int Attack(human theAttacked)
        {
            int theDamage = this.Intelligence*5;
            theAttacked.health -= theDamage;
            this.health += theDamage;
            return theAttacked.health;
        }
        public Wizard(string theirName) : base(theirName)
        {
            health = 50;
            Intelligence = 25;
        }
    }
    class Samurai : human
    {
        public Samurai(string theirName) : base(theirName)
        {
            health = 200;
        }
    }
}

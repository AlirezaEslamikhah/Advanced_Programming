using System;
using A3.Interfaces;
using Environment = A3.Enums.Environment;

namespace A3.Classes.Animals
{
    public class Frog : IAnimal, IWalkable, ISwimable
    {
        public Frog(string name, int age, double health, double speedRate)
        {
            Name = name;Age = age;Health = health;SpeedRate=speedRate;

        }
        
        public string Name { get; set; }
        public int Age { get; set; }
        public double Health { get ; set ; }
        public double SpeedRate { get; set; }

        public string EatFood()
        {
            string v = $"{Name} is a {typeof(Frog).Name} and is eating";
            return v;
        }

        // public string Fly()
        // {
        //     string v = $"{Name} is a {typeof(Frog).Name} and is flying";
        //     return v;
        // }

        public string Move(Environment o)
        {
            if (o.ToString() == "Watery" )
            {
                string y = Swim();
                return y;
            }
            if (o.ToString()=="Land")
            {
                string w = Walk();
                return w;
            }
            else
            {
                string v = $"{Name} is a {typeof(Frog).Name} and can't move in {o.ToString()} environment";
                return v;
            }
        }

        public string Reproduction(IAnimal o)
        {
            string v= $"{Name} is a {typeof(Frog).Name} and reproductive with {o.Name}";
            return v;
        }

        public string Swim()
        {
            string v = $"{Name} is a {typeof(Frog).Name} and is swimming";
            return v;
        }

        public string Walk()
        {
            string v = $"{Name} is a {typeof(Frog).Name} and is walking";
            return v;
        }
    }
    
}
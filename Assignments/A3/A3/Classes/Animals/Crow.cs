using System;
using A3.Interfaces;
using Environment = A3.Enums.Environment;

namespace A3.Classes.Animals
{
    public class Crow : IAnimal, IFlyable
    {
        public Crow(string name, int age, double health, double speedRate)
        {
            Name = name;Age = age;Health = health;SpeedRate=speedRate;

        }

        public string Name { get; set; }
        public int Age { get; set; }
        public double Health { get ; set ; }
        public double SpeedRate { get; set; }

        public string EatFood()
        {
            string v = $"{Name} is a {typeof(Crow).Name} and is eating";
            return v;
        }

        public string Fly()
        {
            string v = $"{Name} is a {typeof(Crow).Name} and is flying";
            return v;
        }

        public string Move(Environment o)
        {
            if (o.ToString() == "Air")
            {
                string y = Fly();
                return y;
            }
            else
            {
                string v = $"{Name} is a {typeof(Crow).Name} and can't move in {o.ToString()} environment";
                return v;
            }
        }

        public string Reproduction(IAnimal o)
        {
            string v= $"{Name} is a {typeof(Crow).Name} and reproductive with {o.Name}";
            return v;
        }
    }
}
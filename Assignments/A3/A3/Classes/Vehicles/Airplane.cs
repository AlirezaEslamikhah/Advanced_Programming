using A3.Interfaces;

namespace A3.Classes.Vehicles
{
    public class Airplane : IFlyable
    {
        public Airplane(double speedRate, string model)
        {
            SpeedRate = speedRate;
            Model = model;


        }

        public double SpeedRate{get;set;}
        public string Model;

        public string Fly()
        {
            // System.Console.WriteLine($"{m} with {SpeedRate} speed rate is flying");
            string v = $"{Model} with {SpeedRate} speed rate is flying";
            return v;
        }
    }
}
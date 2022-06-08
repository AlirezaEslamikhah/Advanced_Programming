using A3.Interfaces;

namespace A3.Classes.Vehicles
{
    public class Submarine : ISwimable
    {
        public Submarine(string model, double maxDepthSupported, double speedRate)
        {
            Model = model;
            MaxDepthSupported = maxDepthSupported;
            SpeedRate = speedRate;
        }

        public double SpeedRate {get;set;}

        public string Swim()
        {
            Submarine o = new Submarine("ff",44,77);
            string v = $"{Model} is a {o.GetType().Name} and is swimming in {MaxDepthSupported} meter depth";
            return v;
        }
        public string Model;
        public double MaxDepthSupported;
    }
}
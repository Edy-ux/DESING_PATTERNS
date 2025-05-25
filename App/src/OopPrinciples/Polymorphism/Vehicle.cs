

namespace design_patterns.src.OopPrinciples.Polymorphism
{
    public class Vehicle
    {

        public string Brand { get; set; } = String.Empty;
        public string Model { get; set; } = String.Empty;
        public int Year { get; set; }

        public virtual void Start()
        {
            Console.WriteLine("The Vehicle is starting");
        }

        public virtual void Stop()
        {
            Console.WriteLine("The Vehicle is stopping ");
        }


    }


}
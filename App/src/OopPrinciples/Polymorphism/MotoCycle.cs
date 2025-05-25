

namespace design_patterns.src.OopPrinciples.Polymorphism
{
    public class MotoCycle : Vehicle
    {
        public int NumberOfWheels { get; set; }

        public override void Start()
        {
            Console.WriteLine("The MotoCycle is starting");

        }
    }

}
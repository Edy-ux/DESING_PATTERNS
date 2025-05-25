namespace design_patterns.src.OopPrinciples.Polymorphism
{
    public class Car : Vehicle
    {
        public string  Name { get; set; }
        public int NumbersOfTheDoors { get; set; }
        public string  Description { get; set; }
        public override void Start()
        {
            Console.WriteLine("The Car is starting");

        }

    }
}
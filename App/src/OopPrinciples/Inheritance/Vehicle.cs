namespace design_patterns.src.OopPrinciples.Inheritance;

public class Vehicle
{

    public string Brand { get; set; } = String.Empty;
    public string Model { get; set; } = String.Empty;
    public int Year { get; set; }

    public void Start()
    {
        Console.WriteLine(" The Vehicle is starting");
    }

    public void Stop()
    {
        Console.WriteLine("The Vehicle is stopping ");
    }


}


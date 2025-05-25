public abstract class Forma
{
    public abstract int CalcularArea();
}
public class Retangulo : Forma
{
    public int Largura { get; set; }
    public int Altura { get; set; }

    public override int CalcularArea()
    {
        return Largura * Altura;
    }
}

public class Quadrado : Forma
{
    public int Lado { get; set; }

    public override int CalcularArea()
    {
        return Lado * Lado;
    }
}



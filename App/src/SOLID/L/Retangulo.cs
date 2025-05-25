
namespace App.src.SOLID.L;


public class Retangulo : Forma
{
    public int Largura { get; set; }
    public int Altura { get; set; }
    public override int CalcularArea()
    {
        return Largura * Altura;
    }
}



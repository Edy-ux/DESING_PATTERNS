

using System.Runtime.Intrinsics.X86;

namespace App.src.SOLID.L;
public class Quadrado : Forma
{
    public int Lado { get; set; }

    public override int CalcularArea()
    {
        return Lado * Lado;
    }

}



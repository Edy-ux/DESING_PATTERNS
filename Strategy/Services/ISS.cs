

namespace Strategy.Services;

//**ConcreteStrategy  Implementações específicas do algoritmo.
public class ISS : ITaxStrategy
{
    public decimal CalculateTax(decimal amount)
    {
        return amount * 0.03m;
    }
}

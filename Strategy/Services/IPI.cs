
namespace Strategy.Services;

//**ConcreteStrategy : Implementações específicas do algoritmo.
public class IPI : ITaxStrategy
{
    public decimal CalculateTax(decimal amount)
    {
        return (amount * 0.5m) / 100;
    }
}

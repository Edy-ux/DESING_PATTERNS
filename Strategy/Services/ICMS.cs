
namespace Strategy.Services;

//**ConcreteStrategy : Implementações específicas do algoritmo.

public class ICMS : ITaxStrategy
{
    public decimal CalculateTax(decimal amount) => amount * 0.05m;

}

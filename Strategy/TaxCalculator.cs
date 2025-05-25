
namespace Strategy;


//Context: Contexto : O contexto mantém uma referência a uma estratégia concreta e pode alterar a estratégia em tempo de execução.
public class TaxCalculator
{
    private ITaxStrategy _taxType;
    public TaxCalculator(ITaxStrategy taxType)
    {
        _taxType = taxType;
    }
    public decimal Calculate(decimal amount) => _taxType.CalculateTax(amount);

    public void SetStrategy(ITaxStrategy taxType)
    {
        _taxType = taxType;
    }
}

// See https://aka.ms/new-console-template for more information
using App.src.SOLID.L;
using Strategy;
using Strategy.Services;

Console.WriteLine("Entry with the tax type");
string? taxType = Console.ReadLine();

if (string.IsNullOrWhiteSpace(taxType))
{
    Console.WriteLine("Tax type cannot be empty.");
}

Console.WriteLine("Enter the amount");
int? amount = Convert.ToInt32(Console.ReadLine());

if (amount == null || amount <= 0)
    Console.WriteLine("Value must be a positive integer.");

ITaxStrategy tax = taxType switch

{
    "ICMS" => new ICMS(),
    "ISS" => new ISS(),
    "IPI" => new IPI(),
    _ => throw new ArgumentException("Invalid tax type")
};


TaxCalculator taxCalculator = new TaxCalculator(tax);

decimal result = taxCalculator.Calculate(amount.Value);

Console.WriteLine($"Taxa para o {amount} para {taxType} é: {result}");



// SOLID - Single Responsibility Principle  

//LSP - Liskov Substitution Principles

List<Forma> formas = new List<Forma>
        {
            new Retangulo { Largura = 5, Altura = 10 },
            new Quadrado { Lado = 5 }
};

foreach (var forma in formas)
{
    Console.WriteLine($"Área: {forma.CalcularArea()}");
}
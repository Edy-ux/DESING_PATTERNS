﻿// See https://aka.ms/new-console-template for more information
using App.src.SOLID.L;
using Strategy;
using Strategy.Services;


//Strategy Patterns 

Console.WriteLine("Entry with the tax type");
string? taxType = Console.ReadLine();

if (string.IsNullOrWhiteSpace(taxType))
{
    Console.WriteLine("Tax type cannot be empty.");
}

Console.WriteLine("Enter the amount");
int amount = Convert.ToInt32(Console.ReadLine());

if (amount == null || amount <= 0)
    Console.WriteLine("Value must be a positive integer.");

ITaxStrategy tax = taxType switch
{
    "ICMS" => new ICMS(),
    "ISS" => new ISS(),
    "IPI" => new IPI(),
    _ => throw new ArgumentException("Invalid tax type")
};

TaxCalculator context = new();
context.SetStrategy(tax);
decimal result = context.Calculate(amount);

Console.WriteLine($"Taxa para {tax.GetType().Name} com base no valor informado é: {result}R$");



// SOLID - Single Responsibility Principle  

//LSP - Liskov Substitution Principles

List<Forma> formas = new()
        {
            new Retangulo { Largura = 5, Altura = 10 },
            new Quadrado { Lado = 5 }
};

foreach (var forma in formas)
{
    Console.WriteLine($"Área: {forma.CalcularArea()}");
}
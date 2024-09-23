using CatelogService.Domain.Primitives;

namespace CatelogService.Domain.ValueObjects;

public sealed class Price : ValueObject
{
    public decimal Amount { get; }
    public string CurrencyCode { get; } = null!;

    private Price(decimal amount, string currencyCode)
    {
        if (amount <= 0) throw new ArgumentException("Amount shold be a positive value.", nameof(amount));

        if(string.IsNullOrWhiteSpace(currencyCode)) throw new ArgumentException("Currency code cannot be null.", nameof(amount));

        if(currencyCode.Length != 3) throw new ArgumentException("Invalid currency code.", nameof(amount));

        Amount = amount;
        CurrencyCode = currencyCode;
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Amount; 
        yield return CurrencyCode;
    }
}

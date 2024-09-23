using CatelogService.Domain.Primitives;

namespace CatelogService.Domain.ValueObjects;

public sealed class Price : ValueObject
{
    public decimal Amount { get; }
    public string Currency { get; } = null!;
    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Amount; 
        yield return Currency;
    }
}

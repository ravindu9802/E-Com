namespace CatelogService.Domain.Primitives;

public abstract class ValueObject : IEquatable<ValueObject>
{

    public abstract IEnumerable<object> GetAtomicValues();

    public bool Equals(ValueObject? other)
    {
       return other is ValueObject && AreValuesEqual(other);
    }

    public override bool Equals(object? obj)
    {
        return obj is ValueObject other && AreValuesEqual(other);
    }

    public override int GetHashCode()
    {
        return GetAtomicValues().Aggregate(default(int), HashCode.Combine);
    }

    private bool AreValuesEqual(ValueObject other)
    {
        return GetAtomicValues().SequenceEqual(other.GetAtomicValues());
    }

}

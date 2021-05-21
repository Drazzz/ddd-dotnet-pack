namespace ddd_dotnet_pack.Domain.Abstractions
{
    public abstract record SingleValueObject<TValue>(TValue Value) : ValueObject
    {
        public override string ToString()
            => ReferenceEquals(Value, null) ? string.Empty : Value.ToString();
    }
}
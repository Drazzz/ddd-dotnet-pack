using System;

namespace ddd_dotnet_pack.Domain.Abstractions
{
    public abstract record Identity(Guid Value) : Identity<Guid>(Value);

    public abstract record Identity<TValue>(TValue Value) : SingleValueObject<TValue>(Value), ITransientable
    {
        public abstract bool IsTransient();

        public override string ToString() => Value.ToString();
    }
}
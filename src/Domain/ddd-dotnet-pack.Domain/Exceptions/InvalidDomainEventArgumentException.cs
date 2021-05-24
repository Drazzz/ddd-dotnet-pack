using ddd_dotnet_pack.Domain.Abstractions.Exceptions;

namespace ddd_dotnet_pack.Domain.Exceptions
{
    public sealed class InvalidDomainEventArgumentException : DomainException
    {
        public InvalidDomainEventArgumentException(string paramName)
            : base($"Cannot add null DomainEvent: {paramName}")
        { }
    }
}
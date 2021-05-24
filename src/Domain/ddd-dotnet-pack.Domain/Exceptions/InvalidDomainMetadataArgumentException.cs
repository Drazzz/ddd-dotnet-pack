using ddd_dotnet_pack.Domain.Abstractions.Exceptions;

namespace ddd_dotnet_pack.Domain.Exceptions
{
    public sealed class InvalidDomainMetadataArgumentException : DomainException
    {
        public InvalidDomainMetadataArgumentException(string paramName)
            : base($"Cannot create DomainMetadata! Argument: {paramName} is not valid.")
        { }
    }
}
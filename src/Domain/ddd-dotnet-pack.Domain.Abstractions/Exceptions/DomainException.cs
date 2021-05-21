using System;

namespace ddd_dotnet_pack.Domain.Abstractions.Exceptions
{
    public abstract class DomainException : ApplicationException
    {
        protected DomainException() { }
        protected DomainException(string message) : base(message) { }
        protected DomainException(string message, Exception innerException) : base(message, innerException) { }
    }
}
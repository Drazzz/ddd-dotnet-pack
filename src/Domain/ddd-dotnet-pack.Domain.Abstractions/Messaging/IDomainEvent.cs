using System;

namespace ddd_dotnet_pack.Domain.Abstractions.Messaging
{
    public interface IDomainEvent : IEvent
    {
        DateTime OccurredOn { get; }
    }
}
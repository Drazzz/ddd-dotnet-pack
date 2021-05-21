using System;

namespace ddd_dotnet_pack.Domain.Abstractions.Messaging
{
    public interface IEvent
    {
        Guid Id { get; }
    }
}
using System.Collections.Generic;
using ddd_dotnet_pack.Domain.Abstractions.Messaging;

namespace ddd_dotnet_pack.Domain.Abstractions
{
    public interface IEventedEntity
    {
        IReadOnlyCollection<IEvent> GetUncommittedChanges();
        void MarkChangesAsCommitted();
    }
}
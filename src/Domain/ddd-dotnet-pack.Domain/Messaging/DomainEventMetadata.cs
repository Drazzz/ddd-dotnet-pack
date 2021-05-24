using System;
using ddd_dotnet_pack.Domain.Exceptions;

namespace ddd_dotnet_pack.Domain.Messaging
{
    public sealed class DomainEventMetadata
    {
        public DateTime CreationDate { get; }
        public DomainEventId EventId { get; }


        private DomainEventMetadata(DomainEventId eventId, DateTime creationDate)
        {
            EventId = eventId ?? throw new InvalidDomainMetadataArgumentException(nameof(eventId));
            CreationDate = creationDate;
        }
        public static DomainEventMetadata From(Guid eventId, DateTime? creationDate) => new(DomainEventId.From(eventId), creationDate ?? SystemClock.Now);
        public static DomainEventMetadata From(DomainEventId eventId) => new(eventId, SystemClock.Now);
        public static DomainEventMetadata Default() => new(DomainEventId.New(), SystemClock.Now);
    }
}
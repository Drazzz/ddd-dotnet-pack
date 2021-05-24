using System;
using ddd_dotnet_pack.Domain.Abstractions;
using ddd_dotnet_pack.Domain.Abstractions.Messaging;
using ddd_dotnet_pack.Domain.Abstractions.Providers;
using MediatR;

namespace ddd_dotnet_pack.Domain.Messaging
{
    public abstract class DomainEvent : IDomainEvent
        , IMetadataProvider<DomainEventMetadata>
        , INotification
    {
        public DomainEventMetadata Metadata { get; }
        public DateTime OccurredOn => Metadata.CreationDate;
        public Identity Id => Metadata.EventId;


        protected DomainEvent(DomainEventMetadata metadata) => Metadata = metadata ?? DomainEventMetadata.Default();
    }
}
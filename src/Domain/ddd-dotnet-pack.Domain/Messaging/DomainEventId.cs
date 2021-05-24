using System;
using ddd_dotnet_pack.Domain.Abstractions;

namespace ddd_dotnet_pack.Domain.Messaging
{
    public sealed record DomainEventId : Identity
    {
        private DomainEventId(Guid id) : base(id) { }

        public static DomainEventId From(Guid id) => new(id);
        public static DomainEventId New() => new(Guid.NewGuid());

        public override bool IsTransient() => Value != Guid.Empty;
    }
}
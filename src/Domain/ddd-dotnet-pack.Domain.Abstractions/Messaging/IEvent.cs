namespace ddd_dotnet_pack.Domain.Abstractions.Messaging
{
    public interface IEvent
    {
        Identity Id { get; }
    }
}
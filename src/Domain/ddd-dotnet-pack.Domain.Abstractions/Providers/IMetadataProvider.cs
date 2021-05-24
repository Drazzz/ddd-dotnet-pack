namespace ddd_dotnet_pack.Domain.Abstractions.Providers
{
    public interface IMetadataProvider<out TMetadata>
        where TMetadata : class
    {
        TMetadata Metadata { get; }
    }
}
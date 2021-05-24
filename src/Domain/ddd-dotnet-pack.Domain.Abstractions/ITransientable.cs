namespace ddd_dotnet_pack.Domain.Abstractions
{
    /// <summary>
    ///     Indicates if type is Transient
    /// </summary>
    public interface ITransientable
    {
        bool IsTransient();
    }
}
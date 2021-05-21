namespace ddd_dotnet_pack.Domain.Abstractions
{
    public interface IBusinessRule
    {
        string Message { get; }
        bool IsBroken();
    }
}
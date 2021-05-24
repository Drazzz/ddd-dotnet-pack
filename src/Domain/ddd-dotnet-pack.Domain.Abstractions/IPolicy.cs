namespace ddd_dotnet_pack.Domain.Abstractions
{
    public interface IPolicy<out TResult>
    {
        TResult Execute();
    }
}
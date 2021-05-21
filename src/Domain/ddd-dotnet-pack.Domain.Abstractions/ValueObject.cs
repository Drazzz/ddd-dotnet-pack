using ddd_dotnet_pack.Domain.Abstractions.Exceptions;

namespace ddd_dotnet_pack.Domain.Abstractions
{
    public abstract record ValueObject
    {
        protected void Check(IBusinessRule rule)
        {
            if (rule.IsBroken())
                throw new BusinessRuleValidationException(rule);
        }
    }
}
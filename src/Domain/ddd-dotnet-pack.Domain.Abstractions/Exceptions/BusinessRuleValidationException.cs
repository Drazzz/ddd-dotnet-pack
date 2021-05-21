﻿namespace ddd_dotnet_pack.Domain.Abstractions.Exceptions
{
    public sealed class BusinessRuleValidationException : DomainException
    {
        public IBusinessRule BrokenBusinessRule { get; }
        public string Details { get; }


        public BusinessRuleValidationException(IBusinessRule businessRule)
            : base(businessRule.Message)
        {
            BrokenBusinessRule = businessRule;
            Details = businessRule?.Message;
        }


        public override string ToString() => $"{BrokenBusinessRule.GetType().FullName}: {BrokenBusinessRule.Message}";
    }
}
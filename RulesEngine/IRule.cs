using System;

namespace RulesEngine
{
    public interface IRule
    {
        IRule SetNext(IRule ruleHandler);
        object Handle(object request);
    }
}

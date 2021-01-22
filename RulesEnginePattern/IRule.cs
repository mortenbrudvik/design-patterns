using System.Collections.Generic;

namespace RulesEnginePattern
{
    public interface IRule
    {
        IReadOnlyCollection<Window> Filter(IReadOnlyCollection<Window> windows);
    }
}
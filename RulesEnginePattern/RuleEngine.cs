using System.Collections.Generic;

namespace RulesEnginePattern
{
    public class RuleEngine
    {
        private readonly List<Window> _windows;

        public RuleEngine(List<Window> windows)
        {
            _windows = windows;
        }

        public IReadOnlyCollection<Window> FilterWindows(IRule searchMethod)
        {
            return searchMethod.Filter(_windows);
        }
    }
}
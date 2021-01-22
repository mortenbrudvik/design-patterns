using System.Collections.Generic;

namespace RulesEnginePattern.Rules
{
    public class Or : IRule
    {
        private readonly IReadOnlyCollection<IRule> _searchMethods;

        public Or(params IRule[] searchMethods)
        {
            _searchMethods = searchMethods;
        }

        public IReadOnlyCollection<Window> Filter(IReadOnlyCollection<Window> windows)
        {
            foreach (var searchMethod in _searchMethods)
            {
                var filteredWindows = searchMethod.Filter(windows);
                if (filteredWindows.Count > 0)
                    return filteredWindows;
            }

            return new List<Window>();
        }
    }
}
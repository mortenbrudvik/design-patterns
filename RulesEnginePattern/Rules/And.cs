using System.Collections.Generic;
using System.Linq;

namespace RulesEnginePattern.Rules
{
    public class And : IRule
    {
        private readonly IReadOnlyCollection<IRule> _searchMethods;

        public And(params IRule[] searchMethods)
        {
            _searchMethods = searchMethods;
        }

        public IReadOnlyCollection<Window> Filter(IReadOnlyCollection<Window> windows)
        {
            var filteredWindows = windows;

            foreach (var searchMethod in _searchMethods)
            {
                filteredWindows = searchMethod.Filter(filteredWindows).ToList();
                if (filteredWindows.Count == 0)
                    return new List<Window>();
            }

            return filteredWindows;
        }
    }
}
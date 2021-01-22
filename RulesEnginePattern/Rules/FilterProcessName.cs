using System.Collections.Generic;
using System.Linq;

namespace RulesEnginePattern
{
    public sealed class FilterProcessName : IRule
    {
        private readonly string _searchText;

        public FilterProcessName(string searchText)
        {
            _searchText = searchText;
        }

        public IReadOnlyCollection<Window> Filter(IReadOnlyCollection<Window> windows)
        {
            return windows.Where(window => window.ProcessName.Contains(_searchText)).ToList();
        }
    }
}
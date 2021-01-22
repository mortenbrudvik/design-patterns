using System.Collections.Generic;
using System.Linq;

namespace RulesEnginePattern
{
    public sealed class FilterWindowTitle : IRule
    {
        private readonly string _searchText;

        public FilterWindowTitle(string searchText)
        {
            _searchText = searchText;
        }

        public IReadOnlyCollection<Window> Filter(IReadOnlyCollection<Window> windows)
        {
            return windows.Where(window => window.Title.Contains(_searchText)).ToList();
        }
    }
}
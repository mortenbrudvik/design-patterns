using System.Collections.Generic;
using System.Linq;

namespace RulesEnginePattern
{
    public sealed class WindowClassNameFilter : IRule
    {
        private readonly string _searchText;

        public WindowClassNameFilter(string searchText)
        {
            _searchText = searchText;
        }

        public IReadOnlyCollection<Window> Filter(IReadOnlyCollection<Window> windows)
        {
            return windows.Where(window => window.ClassName.Contains(_searchText)).ToList();
        }
    }
}
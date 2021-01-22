using System;

namespace RulesEnginePattern
{
    public class Window
    {
        public Window(string title, string className, string processName)
        {
            Title = title;
            ClassName = className;
            ProcessName = processName;
        }
        public string Id { get; } = Guid.NewGuid().ToString();
        public string ClassName { get; }
        public string Title { get; }
        public string ProcessName { get; }

        public override string ToString() => $"Title: {Title}, ClassName: {ClassName}, ProcessName: {ProcessName}";
    }
}
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using RulesEnginePattern;
using RulesEnginePattern.Rules;
using static System.Console;

var windows = new List<Window>()
{
    new("Untitled - Notepad", "Notepad", "notepad"),
    new("Excel document", "Excel", "EXCEL"),
    new("Notepad document", "Notepad", "notepad"),
    new("google.com", "Chrome_WidgetWin_1", "chrome"),
    new("bing.com", "Chrome_WidgetWin_1", "chrome"),
    new("bing.com", "Chrome_WidgetWin_1", "msedge"),
    new("Task Manager", "TaskManagerWindow", "Taskmgr")
};

var windowFilter = new FilterWindowClassName("Notepad");
Out.WriteLine("WindowClassFilter: Notepad");
FilterWindows(windowFilter, windows);

var windowFilter2 = new FilterWindowTitle("bing.com");
Out.WriteLine("WindowTitleFilter: bing.com");
FilterWindows(windowFilter2, windows);


var windowFilter3 = new And(new FilterWindowTitle("bing.com"), new FilterProcessName("msedge"));
Out.WriteLine("WindowTitleFilter: bing.com && ProcessNameFilter: msedge");
FilterWindows(windowFilter3, windows);

var windowFilter4 = new Or(new FilterWindowClassName("Excel"), 
                            new And(new FilterWindowTitle("bing.com"), new FilterProcessName("msedge")));
Out.WriteLine("WindowClassNameFilter: Excel || (WindowTitleFilter: bing.com && ProcessNameFilter: msedge)");
FilterWindows(windowFilter4, windows);


static void FilterWindows(IRule windowClassNameFilter, List<Window> windows)
{
    var ruleEngine = new RuleEngine(windows);

    ruleEngine.FilterWindows(windowClassNameFilter).ToList()
        .ForEach(x => Out.WriteLine(x));
    Out.WriteLine("");
}




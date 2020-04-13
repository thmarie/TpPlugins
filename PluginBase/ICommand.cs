using System.Collections;

namespace PluginBase
{
    public interface ICommand
    {
        string[] jSon { get; }

        ArrayList Execute();
    }
}
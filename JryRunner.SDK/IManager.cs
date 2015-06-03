using System.Collections.Generic;

namespace JryRunner.SDK
{
    public interface IManager<out T>
        where T : IRunnerTarget
    {
        IEnumerable<T> Search(string keyword);
    }
}
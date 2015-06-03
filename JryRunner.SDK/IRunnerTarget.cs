using System.Security.Cryptography.X509Certificates;

namespace JryRunner.SDK
{
    public interface IRunnerTarget
    {
        RunnerMode Mode { get; }

        void Open();

        void StartWith(string fileName);
    }
}
using System.Diagnostics;

namespace JryRunner.SDK.Helper
{
    public static class Opener
    {
        public static void OpenWithProcess(string uri)
        {
            Process.Start(uri);
        }
    }
}
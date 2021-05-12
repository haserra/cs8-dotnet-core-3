using static System.Console;

namespace Packt.Shared
{
    public interface IPlayable
    {
        void Play();

        void Pause();

        // Adding a Stop method with a default implementation
        // This is only supported with C# 8.0 if the target framework is either .NET Core 3.0 or .NET Standard 2.1
        void Stop()
        {
            WriteLine("Default implementation of Stop.");
        }
    }
}
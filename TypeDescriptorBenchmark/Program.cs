using BenchmarkDotNet.Running;

namespace TypeDescriptorBenchmark
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Test>();
        }
    }
}

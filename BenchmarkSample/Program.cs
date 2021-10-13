using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace BenchmarkSample
{
    public class BenchmarkSample
    {
        public BenchmarkSample()
        {
            // Setup your benchmark here
        }

        [Benchmark]
        public void Function1()
        {
        }

        [Benchmark]
        public void Function2()
        {
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<BenchmarkSample>();
        }
    }
}

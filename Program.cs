﻿using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simd_workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            // BenchmarkRunner.Run<BranchPrediction>();
            // BenchmarkRunner.Run<MinMax>();
            // BenchmarkRunner.Run<Cache>();
            // BenchmarkRunner.Run<CacheInvalidation>();
            BenchmarkRunner.Run<SimpleVectors>();
            // BenchmarkRunner.Run<Mandelbrot>();
            // BenchmarkRunner.Run<Particles>();
            // BenchmarkRunner.Run<AdvancedVectors>();
        }
    }
}

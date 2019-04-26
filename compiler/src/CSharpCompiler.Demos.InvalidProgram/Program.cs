using System;

namespace CSharpCompiler.Demos.InvalidProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmas = new Christmas();
        }
    }


    struct Gift<T>
    {
    }

    struct Christmas
    {
        public Gift<Christmas> WrappedGift { get; set; }
    }
}

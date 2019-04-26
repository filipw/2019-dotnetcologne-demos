using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCompiler.Demos.OpenGeneric
{
    class Program
    {
        static void Main()
        {
            var normal = Enum.ToObject(typeof(Gift.Color), 0);
            var normalTyped = Enum.ToObject(typeof(Gift<string>.Color), 0);
            var weird = Enum.ToObject(typeof(Gift<>.Color), 0);

            Console.WriteLine(normal.GetType());
            Console.WriteLine(normal.GetType().IsGenericTypeDefinition);

            Console.WriteLine(normalTyped.GetType());
            Console.WriteLine(normalTyped.GetType().IsGenericTypeDefinition);

            Console.WriteLine(weird.GetType());
            Console.WriteLine(weird.GetType().IsGenericTypeDefinition);

            Console.ReadLine();
        }
    }


    class Gift<T>
    {
        public enum Color { }
    }

    class Gift
    {
        public enum Color { }
    }
}

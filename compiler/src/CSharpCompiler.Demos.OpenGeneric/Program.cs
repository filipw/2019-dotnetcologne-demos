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

            Inspect(normal);
            Inspect(normalTyped);
            Inspect(weird);
        }

        private static void Inspect(object o)
        {
            Console.WriteLine(o);
            Console.WriteLine(o.GetType());
            Console.WriteLine(o.GetType().IsGenericTypeDefinition);

            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
        }
    }


    class Gift<T>
    {
        public enum Color { Green, Blue }
    }

    class Gift
    {
        public enum Color { Yellow, Red }
    }
}

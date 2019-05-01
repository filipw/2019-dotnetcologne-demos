using System;

namespace CSharpCompiler.Demos.InvalidProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var defaultLeaf = Leaf.Default;
            var tree = new Tree();
        }
    }


    // type definition is recursive but the struct layout is not - the field is static
    // reason for the failure is that both the instance and static layout are done together
    struct Leaf
    {
        public static readonly Leaf? Default = null;
    }

    // legal type topology in C#
    struct Node<T>
    {
    }

    struct Tree
    {
        public Node<Tree> Node { get; set; }
    }
}

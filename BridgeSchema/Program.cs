using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var classimplementationfirst = new BridgeImplementation(new ClassImplementationFirst());

            classimplementationfirst.GetMethod();

            Console.ReadKey();
        }
    }
}

using System;
using System.Reactive.Linq;

namespace ReactiveExtension.HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = Observable
                .Range(1, 10)
                .Select(x => 10 / (5 - x));

            list.Subscribe(
                x  => Console.WriteLine($"Received {x}"),
                ex => Console.WriteLine($"An error has occurred on value {ex}"),
                () => Console.WriteLine("Done"));

            Console.ReadLine();
        }
    }
}

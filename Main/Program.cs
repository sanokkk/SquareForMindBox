using Square;
using System;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var test = new SquareCounter();
            test.GetSquare(10);
            var sq = test.Square;
            Console.WriteLine(sq);
        }
    }
}

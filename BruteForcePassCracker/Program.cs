using System;

namespace BruteForcePassCracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = DateTime.Now.Ticks;
            var brutus = new Brutus("heslo");
            brutus.Crack();
            var end = DateTime.Now.Ticks;
            var time = end - start;
            Console.WriteLine(time);
        }
    }
}
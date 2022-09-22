using System;
using System.Linq;
using BruteForcePassCracker;
using NUnit.Framework;

namespace BruteForceTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {

            for ( int i = 1; i < 7; i++ )
            {
                
                var brutus = new Brutus(RandomString(i));
                var start = DateTime.Now;
                brutus.Crack();
                var end = DateTime.Now;
                var time = end - start;
                Console.WriteLine(time.TotalMilliseconds);                
            }

            Assert.Pass();
        }
        
        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray()).ToLower();
        }
    }
}
using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {

            var i = 20;
            Console.WriteLine("i = {0}", i);

            i = i + 1;
            Console.WriteLine("i = {0}", i);

            i += 2;
            Console.WriteLine("i = {0}", i);
            Console.WriteLine("i = {0}.", --i);
            Console.WriteLine("i = {0}, but now is {1} again.", i--, i);
        }
    }
}

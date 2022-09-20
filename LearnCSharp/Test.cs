using System;
using System.Linq;

namespace LearnCSharp
{
    public static class Test
    {
        public static void Print<T>(this T[] source)
        {
            if (!source.Any())
            {
                Console.WriteLine("{}"); return;
            }
            Console.Write("{");
            foreach (var item in source)
            {
                Console.Write($"{item},");
            }
            Console.Write("}");
            Console.WriteLine();
        }

    }




}

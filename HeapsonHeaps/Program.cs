using System;
using System.Collections.Generic;

namespace HeapsonHeaps
{
    class Program
    {
        static void Main(string[] args)
        {
            Heap h = new Heap();

            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                h.insert(rnd.Next(1, 20));
            }

            while (h.Count > 0)
            {
                Console.WriteLine(h.pop());
            }
        }
    }
}

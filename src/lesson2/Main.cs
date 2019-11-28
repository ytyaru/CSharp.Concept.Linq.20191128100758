using System;
using System.Linq;
using System.Collections.Generic;

namespace Concept.Linq.Lesson2 {
    class Main {
        public void Run() {
            int[] a = new int[] { 1, 2, 3, 4, 5 };
            int count = (from v in a
                                 where 1 == (v % 2)
                                 select $"v={v}").Count();
            Console.WriteLine($"odd={count}");
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace Concept.Linq.Lesson1 {
    class Main {
        public void Run() {
            int[] a = new int[] { 1, 2, 3, 4, 5 };
            IEnumerable<string> b = from v in a
                                 where 1 == (v % 2)
                                 select $"v={v}";
            foreach (string v in b) {
                Console.WriteLine(v);
            }
        }
    }
}

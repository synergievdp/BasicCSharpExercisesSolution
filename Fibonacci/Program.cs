using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Fibonacci {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine(String.Join(',', Fibonacci(10, -1)));
            Console.WriteLine(Fibonacci(-1, int.MaxValue).Count());
            Console.WriteLine(Fibonacci(int.MaxValue, int.MaxValue).Count());
            Console.WriteLine(Fibonacci(0, 0).Count());
            Console.WriteLine(Fibonacci(-1, 0).Count());
            Console.WriteLine(Fibonacci(int.MinValue, int.MinValue).Count());

            Console.WriteLine("Press <ENTER> to exit...");
            Console.ReadLine();
        }

        // steps / target -> uint or nullable?
        // Overloading with same method signatures?
        // Biggest Int32?
        static IEnumerable<int> Fibonacci(int steps, int target) {
            if (steps < 0)
                steps = int.MaxValue;
            if (target < 0)
                target = int.MaxValue;

            List<int> sequence = new();

            for (int i = 0; i < steps; i++) {
                int next = sequence.Count == 0 ? 0 : (sequence.Count == 1 ? 1 : sequence[^1] + sequence[^2]);

                if (next > target || next < 0)
                    break;

                sequence.Add(next);
                //yield return next;

            }

            return sequence;
        }
    }
}

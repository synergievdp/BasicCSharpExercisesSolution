using System;
using System.Linq;
using System.Text;

namespace Spacer {
    class Program {
        const char Space = ' ';
        static void Main(string[] args) {
            string text = "hello";
            string text2 = "I'm counting 1, 2, 3, ...";

            Console.WriteLine(Spacer(null));
            Console.WriteLine(Spacer(text2));
            Console.WriteLine(Spacer(text, 0));
            Console.WriteLine(Spacer(text, -1));
            Console.WriteLine(Spacer(text, 5));
            Console.WriteLine(Spacer(text, 1, '€'));
            Console.WriteLine(Spacer(text, 1, '*'));
            Console.WriteLine(Spacer(text2, 1, '*'));

            Console.WriteLine("Press <ENTER> to exit...");
            Console.ReadLine();
        }

        // int amount -> uint or nullable?
        // skip preexisting whitespaces?
        // whitespace/seperator at the end?
        // 1c -> only one word or multiple words like 1a?
        static string Spacer(string text, int amount, char seperator) {
            if (String.IsNullOrWhiteSpace(text))
                return String.Empty;

            if (amount < 0)
                amount = 3;
            if (!" +*-#".Contains(seperator))
                seperator = Space;
            string filler = new(seperator, amount);

            StringBuilder sb = new();
            sb.AppendJoin(filler, text.Where(c => !char.IsWhiteSpace(c))); // text.ToCharArray();

            return sb.ToString();
        }

        static string Spacer(string text, int amount) {
            return Spacer(text, amount, Space);
        }

        static string Spacer(string text) {
            return Spacer(text, 3, Space);
        }
    }
}

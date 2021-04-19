using System;
using System.Text;

namespace ChristmasTree {
    class Program {
        const char Tilde = '~';
        const char Space = ' ';

        static void Main(string[] args) {
            //ChristmasTree(null);
            //ChristmasTree(String.Empty);
            //ChristmasTree(" ");
            //ChristmasTree("christmas");
            ChristmasTree("More characters than Christmas tree");

            Console.WriteLine("Press <ENTER> to exit...");
            Console.ReadLine();
        }

        static void ChristmasTree(string text) {
            string christmasTree = "Christmas tree";
            text += new string(Tilde, String.IsNullOrEmpty(text)?christmasTree.Length:Math.Max(0, christmasTree.Length - text.Length));
            text = text.Replace(Space, Tilde);

            string[] tree = new string[text.Length];

            int top = (int)(text.Length * 0.8);
            int maxSize = 2 * top;
            for(int i = 0; i < top; i++) {
                tree[i] = new string(text[i], 2 * (i + 1) - 1).PadCenter(maxSize);
            }

            int bottom = text.Length - top;
            int trunkWidth = 3;
            for (int i = 1; i <= bottom; i++) {
                tree[^i] = new string(text[^i], trunkWidth).PadCenter(maxSize);
            }

            for(int i = 0; i < text.Length; i++) {
                Console.ForegroundColor = i % 2 == 0 ? ConsoleColor.Green : ConsoleColor.DarkGreen;
                Console.WriteLine(tree[i]);
            }
            Console.ResetColor();
        }
    }

    static class StringExtensions {
        static public string PadCenter(this string text, int totalWidth) {
            return text.PadLeft(text.Length + (totalWidth - text.Length) / 2).PadRight(totalWidth);
        }
    }
}

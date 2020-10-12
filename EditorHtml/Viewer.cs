using System;
using System.Text.RegularExpressions;

namespace EditorHtml
{
    public class Viewer
    {
        public static void Show(String text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.Clear();

            Console.WriteLine("MODO DE VISUALIZAÇÃO");
            Console.WriteLine("--------------");
            Replace(text);
            Console.WriteLine("--------------");
            Console.ReadKey();
            Menu.Show();
        }


        public static void Replace(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(' ');

            for (var i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(
                        words[i].Substring(
                             words[i].IndexOf('>') + 1,
                             (
                                (words[i].LastIndexOf('<') - 1) -
                                words[i].IndexOf('>')
                           )
                        )
                    );
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filip
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.Write(Compare(text));
        }

        public static string ReadFirstNumber(string input)
        {
            List<char> chars = new List<char>();
            for (int i = 2; i >= 0; i--)
            {
                chars.Add(input[i]);
            }

            return new string(chars.ToArray());
        }

        public static string ReadSecondNumber(string input)
        {
            List<char> chars = new List<char>();
            for (int i = 6; i >= 4; i--)
            {
                chars.Add(input[i]);
            }

            return new string(chars.ToArray());
        }

        public static string Compare(string text)
        {
            List<Tuple<int, int>> pairs = new List<Tuple<int, int>>
            {
                new Tuple<int, int>(2, 6),
                new Tuple<int, int>(1, 5),
                new Tuple<int, int>(0, 4)
            };

            foreach (var pair in pairs)
            {
                int firstDigit = int.Parse(text[pair.Item1].ToString());
                int secondDigit = int.Parse(text[pair.Item2].ToString());
                if (firstDigit > secondDigit)
                {
                    return ReadFirstNumber(text);
                }
                else if (secondDigit > firstDigit)
                {
                    return ReadSecondNumber(text);
                }
            }

            return ReadFirstNumber(text);
        }
    }
}

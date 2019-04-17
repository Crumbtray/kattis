using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseltonguesPractice3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Compare(text);
        }

        public static void ReadFirstNumber(string input)
        {
            for(int i = 2; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
        }

        public static void ReadSecondNumber(string input)
        {
            for (int i = 6; i >= 4; i--)
            {
                Console.Write(input[i]);
            }
        }

        public static void Compare(string text)
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
                    ReadFirstNumber(text);
                    return;
                }
                else if (secondDigit > firstDigit)
                {
                    ReadSecondNumber(text);
                    return;
                }
            }
        }
    }
}

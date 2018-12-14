using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetSerializer
{
    class Program
    {
        const int TOTAL_ALPHABETIC_LETTERS = 26;
        static void Main(string[] args)
        {
            //declare a queue array of the letters of the alphabet
            Queue<char> alpQue = new Queue<char>();

            StringBuilder result = new StringBuilder();
            StringBuilder finalResult = new StringBuilder();

            //add items to the character array
            for (int i = 0; i < TOTAL_ALPHABETIC_LETTERS; i++)
            {
                alpQue.Enqueue((char)('A' + i));
            }

            while (alpQue.Count > 1)
            {
                foreach (char item in alpQue)
                {
                    result.Append(item);
                    finalResult.AppendLine(result.ToString());
                }
                Console.WriteLine(finalResult.ToString());

                alpQue.Dequeue();
                result.Clear();
                finalResult.Clear();
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephone
{
    internal class Telephone
    {
        public static string GetFirstWord(string heardWord)
        {
            return heardWord;
        }

        public static int GetRandomNumber()
        {
            Random random = new Random();
            int randomNumberFrom1To10 = new Random().Next(1, 11);
            return randomNumberFrom1To10;
        }
        public static string ScrambleWord(string heardWord)
        {
            string scrambledWord = "hoseu";
            return scrambledWord;
        }

    }
}

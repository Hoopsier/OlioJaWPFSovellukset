using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT_Harj_12
{
    static class CardShuffle // everything here uses the Fisher–Yates shuffle https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle
    {
        public static void Shuffle<T>(this Random rng, List<T> kortit)
        {
            //length of deck
            int n = kortit.Count;
            //glorified for loop for shuffling
            while (n > 1)   
            {
                int k = rng.Next(n--);
                T temp = kortit[n];
                kortit[n] = kortit[k];
                kortit[k] = temp;
            }
        }
    }
}

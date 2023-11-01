using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Extension_HomeWork.NewFolder
{
    public static class Extension
    {
        ////Task 1
        public static bool IsPrime(this int a)
        {
            switch (a)
            {
                case 0:
                case 1:
                    Console.WriteLine("ne sade nede murekkeb ededdir!");

                    break;
                case 2:
                case 3:
                case 7:
                    return true;

            }
            if (a % 2 == 0)
            {
                return false;
            }

            for (int i = 3; i * i <= a; i += 2)
            {
                if (a % i == 0)
                {
                    return false;
                }

            }
            return true;
        }
 
        public static bool IsPowOfTwo(this int b)
        {
            for (int i = 2; i <= b; i *= 2)
            {
                if (i == b)
                {
                    return true;
                }
            }
            return false;

        }
    }
}
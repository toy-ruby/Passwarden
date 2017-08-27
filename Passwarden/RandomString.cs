using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passwarden
{
    class RandomString
    {
        String returnString = "";
        ushort length;
        uint[,] charSet = new uint[4,2];

        /// <summary>
        /// Create an empty RandomString object
        /// </summary>
        public RandomString()
        {
        }

        public RandomString(ushort length, ushort charSet)
        {
        }

        /// <summary>
        /// Constructor that takes an Options object
        /// </summary>
        /// <param name="options"></param>
        public RandomString(Options options)
        {
            if(options.CaseSensitive)
            {
                // a - z
                charSet[0,0] = 97;
                charSet[0,1] = 122;

                // A - Z
                charSet[1, 0] = 65;
                charSet[1, 1] = 90;
            }
            if(options.Nonsensitive)
            {
                // a - z
                charSet[0, 0] = 97;
                charSet[0, 1] = 122;
            }
            if(options.Numeric)
            {
                // 0 - 9
                charSet[2, 0] = 48;
                charSet[2, 0] = 57;
            }
            if(options.Punctuation)
            {
                // ! - /
                charSet[3, 0] = 33;
                charSet[3, 1] = 47;
            }
        }

        /// <summary>
        /// A randomized String of len characters
        /// </summary>
        /// <param name="len"></param>
        /// <returns></returns>
        public String getString(ushort len)
        {
            String ret = "";
            Random rnd = new Random();
            uint current = (uint)rnd.Next();
            int[] set = new int[len];

            // Fill the array with ASCII compatible random values
            for (int i = 0; i < len; i++)
            {
                int code = Convert.ToInt16(100 * rnd.NextDouble());
                code = closetToCharset(code);
                //code = rangeCheck(code, 97, 122);
                ret += Convert.ToChar(code);
            }

            return ret;
        }

        /// <summary>
        /// Returns int that is within a ceratin range based on proximity to num
        /// <para>The value of num will increase if below range and decrease if above range until it is within range</para>
        /// </summary>
        /// <param name="num"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>
        private int rangeCheck(int num, int low, int high)
        {
            bool ok = false;

            while (!ok)
                if (num > high)
                {
                    num -= high;
                }
                else if (num < low)
                {
                    num += low;
                }
                else
                {
                    ok = true;
                }

            //while (!ok)
            //{
            //    if (num > high)
            //    {
            //        num = num - (num - high);
            //    }
            //    else if (num < low)
            //    {
            //        num = num + (low - num);
            //    }
            //    else
            //    {
            //        ok = true;
            //    }
            //}

            return num;
        }

        /// <summary>
        /// Returns the value of the nearest int to num within the given ranges of charSet
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private int closetToCharset(int num)
        {
            for(int i = 0; i < charSet.Length / charSet.Rank; i++)
            {
                // TODO
            }

            return num;
        }
    }
}

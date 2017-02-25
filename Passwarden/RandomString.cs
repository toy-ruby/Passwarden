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
        ushort charSet;

        public RandomString()
        {

        }

        public RandomString(ushort length, ushort charSet)
        {
        }

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
                code = rangeCheck(code, 97, 122);
                ret += Convert.ToChar(code);

            }

            return ret;
        }

        // Modify num to be between low and high
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
            return num;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using MathNet.Numerics.Statistics;

namespace APP
{
    public static class Func
    {
        /// <summary>
        /// 
        /// </summary>

        public static DateTime ConvDateTime(string srcdata)
        {
            try
            {
                return DateTime.Parse(srcdata);
            }
            catch
            {
                return DateTime.MaxValue;
            }
        }

        public static int ConvInt(string srcdata)
        {
            try
            {
                return Int32.Parse(srcdata);
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// 
        /// </summary>

        public static int int2asc(int src)
        {
            if (src < 10) return (src + 0x30);
            else if (src < 16) return ((src - 10) + 0x41);
            else return 0;
        }

        public static int asc2int(int src)
        {
            if (src > 0x40) return (src - 0x41 + 10);
            else if (src >= 0x30) return (src - 0x30);
            else return 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leo.Extensions
{
    public static class StringConvertExtension
    {
        /// <summary>
        /// 字符串转长整形
        /// </summary>
        /// <param name="value"></param>
        /// <param name="defVal"></param>
        /// <returns></returns>
        public static long ToLong(this string value, long defVal = 0)
        {
            long l;
            if (!long.TryParse(value, out l))
            {
                l = defVal;
            }
            return l;
        }

        /// <summary>
        /// 字符串转无符号长整形
        /// </summary>
        /// <param name="value"></param>
        /// <param name="defVal"></param>
        /// <returns></returns>
        public static ulong ToULong(this string value, ulong defVal = 0)
        {
            ulong l;
            if (!ulong.TryParse(value, out l))
            {
                l = defVal;
            }
            return l;
        }

        /// <summary>
        /// 字符串转短整形
        /// </summary>
        /// <param name="value"></param>
        /// <param name="defVal"></param>
        /// <returns></returns>
        public static short ToShort(this string value, short defVal = 0)
        {
            short l;
            if (!short.TryParse(value, out l))
            {
                l = defVal;
            }
            return l;
        }

        /// <summary>
        /// 字符串转无符号短整形
        /// </summary>
        /// <param name="value"></param>
        /// <param name="defVal"></param>
        /// <returns></returns>
        public static ushort ToUShort(this string value, ushort defVal = 0)
        {
            ushort l;
            if (!ushort.TryParse(value, out l))
            {
                l = defVal;
            }
            return l;
        }

        /// <summary>
        /// 字符串转整形
        /// </summary>
        /// <param name="value"></param>
        /// <param name="defVal"></param>
        /// <returns></returns>
        public static int ToInt(this string value, int defVal = 0)
        {
            int i;
            if (!int.TryParse(value, out i))
            {
                i = defVal;
            }
            return i;
        }

        /// <summary>
        /// 字符串转整形
        /// </summary>
        /// <param name="value"></param>
        /// <param name="defVal"></param>
        /// <returns></returns>
        public static uint ToUInt(this string value, uint defVal = 0)
        {
            uint i;
            if (!uint.TryParse(value, out i))
            {
                i = defVal;
            }
            return i;
        }

        /// <summary>
        /// 字符串转decimal
        /// </summary>
        /// <param name="value"></param>
        /// <param name="defVal"></param>
        /// <returns></returns>
        public static decimal ToDecimal(this string value, decimal defVal = 0)
        {
            decimal d;
            if (!decimal.TryParse(value, out d))
            {
                d = defVal;
            }

            return d;
        }

        /// <summary>
        /// 字符串转float
        /// </summary>
        /// <param name="value"></param>
        /// <param name="defVal"></param>
        /// <returns></returns>
        public static float ToFloat(this string value, float defVal = 0)
        {
            float f;
            if (!float.TryParse(value, out f))
            {
                f = defVal;
            }

            return f;
        }

        /// <summary>
        /// 字符串转double
        /// </summary>
        /// <param name="value"></param>
        /// <param name="defVal"></param>
        /// <returns></returns>
        public static double ToDouble(this string value, double defVal = 0)
        {
            double d;
            if (!double.TryParse(value, out d))
            {
                d = defVal;
            }

            return d;
        }

        /// <summary>
        /// 字符串转Boolean
        /// </summary>
        /// <param name="value"></param>
        /// <param name="defVal"></param>
        /// <returns></returns>
        public static bool ToBoolean(this string value, bool defVal = false)
        {
            bool d;
            if (!bool.TryParse(value, out d))
            {
                d = defVal;
            }

            return d;
        }
    }
}

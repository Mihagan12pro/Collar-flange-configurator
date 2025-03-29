using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collar_flange_configurator.Extensions
{
    public static class StringExtensions
    {
        public static double ToDouble(this string str)
        {
            return Convert.ToDouble(str);
        }
        public static int ToInt32(this string str)
        {
            return Convert.ToInt32(str);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppCommon.Util
{
    public class StringUtil
    {
        public static string ToEmpty(object value)
        {
            if (value == null)
            {
                return string.Empty;
            }
            return value.ToString();
        }
    }
}

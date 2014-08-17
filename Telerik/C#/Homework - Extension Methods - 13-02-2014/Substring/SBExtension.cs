using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring
{
    /* 01.
     * Implement an extension method Substring(int index, int length) for the class StringBuilder
     * that returns new StringBuilder and has the same functionality as Substring in the class String.
     */

    public static class SBExtension
    {
        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            return new StringBuilder(sb.ToString().Substring(index, length));
        }
    }
}

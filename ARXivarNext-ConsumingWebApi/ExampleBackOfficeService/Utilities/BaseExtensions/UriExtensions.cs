using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleBackOfficeService.Utilities.BaseExtensions
{
    public static class UriExtensions
    {
        public static string ConcatUrls(this string firstPart, string secondPart)
        {
            if (firstPart.EndsWith("/") == false)
            {
                if (secondPart.StartsWith("/") == false)
                {
                    return firstPart + "/" + secondPart;
                }
                return firstPart + secondPart;
            }
            if (secondPart.StartsWith("/") == true)
            {
                firstPart = firstPart.TrimEnd(new char[] { '/' });
            }
            return firstPart + secondPart;
        }
    }
}

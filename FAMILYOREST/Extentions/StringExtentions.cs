using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAMILYOREST.Extentions
{
    public static class StringExtentions


    {

        public static string SayHello(this string name)

            {
            return $"Hello {name}.";
            }

        public static bool ZipTest(this string myzip)

        {
            return myzip.Length == 5 || myzip.Length == 9;
        }


    }
}

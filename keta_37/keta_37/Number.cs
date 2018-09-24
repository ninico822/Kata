using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keta_37
{
    public class Number
    {
        public static long DigitalRoot(long n)
        {
            while (n / 10 > 0)
            {
                n = n.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).Aggregate((total, next) => total + next);
            }
            return n;
        }
    }
}

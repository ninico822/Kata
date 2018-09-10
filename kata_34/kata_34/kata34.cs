using System;
using System.Linq;


namespace kata_34
{
    public class kata34
    {
        public static int Persistence(long n)
        { 
            var times = 0;
            while (n/10 > 0)
            {
                n = n.ToString().ToCharArray().ToList().Select(x=> (int)Char.GetNumericValue(x)).Aggregate((total, next) => total * next);
                times++;
            }
            return times;
        }
    }
}

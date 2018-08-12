using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata_30
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] s1 = new string[] { "hoqq", "bbllkw", "oox", "ejjuyyy", "plmiis", "xxxzgpsssa", "xxwwkktt", "znnnnfqknaz", "qqquuhii", "dvvvwz" };
            string[] s2 = new string[] { "cccooommaaqqoxii", "gggqaffhhh", "tttoowwwmmww" };

            Program.Mxdiflg(s1, s2);
        }

        public static int Mxdiflg(string[] a1, string[] a2)
        {
            if (a1.Length != 0 && a2.Length != 0)
            {
                var result1 = a1.Max(x => x.Length) - a2.Min(x => x.Length);
                var result2 = a2.Max(x => x.Length) - a1.Min(x => x.Length);
                return result1 > result2 ? result1 : result2;
            }
            else
            {
                return -1;
            }



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace kata_35
{
    public class Class1
    {
        public static int GetVowelCount(string str)
        {
            var strList = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            return str.ToCharArray().Count(x => strList.Contains(x));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata_31
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = "scout";
            Encode(input,1939);
        }

        public static List<int> Encode(string str,int n)
        {
            var inputStr = GetIndexOfValue(str.ToCharArray());
            var inputNum = n.ToString().Select(x => int.Parse(x.ToString())).ToList();
            return GetEncodeResult(inputStr,inputNum);
        }

        private static List<int> GetEncodeResult(List<int> arr,List<int> num)
        {
            //19,3,15,21,20
            List<int> resultArr = new List<int>();
            int index = 0;

            foreach (var item in arr)
            {
                resultArr.Add(item + num[index % 4]);
                index++;
            }
            return resultArr;

        }

        public static List<int> GetIndexOfValue(char[] str)
        {
            char[] enArr = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
            List<int> intValue = new List<int>();
            foreach (char item in str)
            {
                intValue.Add(Array.IndexOf(enArr, item) + 1);
            }
            return intValue;
        }
    }
}

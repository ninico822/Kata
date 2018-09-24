using System.Linq;

namespace kata_36
{
    public class Class1
    {   

        public static int Find(int[] integers)
        {

            var getNumType = integers.ToList().Aggregate(0,(total, next) => total + next%2);
            var num = getNumType > 1 ? integers.ToList().First(x => x % 2 == 0) : integers.ToList().First(x => x % 2 == 1);

            return num;
        }
    }
}

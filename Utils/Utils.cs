using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Utils
    {
        static public int Sum(int x, int y, out int result)
        {
            result = x + y;
            return result;
        }

        static public int SumArray(params int[] values)
        {
            int result = 0;
            foreach (int value in values)
                result += value;
            return result;
        }
        static public void ShowResultSum(string str,params int[] values)
        {
            int result = 0;
            foreach (int value in values)
                result += value;
            str += result;
            Console.WriteLine(str);
        }
    }
}

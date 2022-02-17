using System;
using System.Collections.Generic;
namespace Task6
{
    class Program
    {
        public static IEnumerator<int> GetEnum(int[] arr)
        {
            foreach (var item in arr)
            {
                if (item % 2 == 0)
                {
                    yield return item;
                }
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
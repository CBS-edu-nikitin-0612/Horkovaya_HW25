using System;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();
            for (int i = 1; i <= 3; i++)
            {
                dictionary.Add(i, Console.ReadLine());
            }
            Console.WriteLine("");
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }
        }
    }
}
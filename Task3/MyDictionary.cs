using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class MyDictionary<T, K>: IMyDictionary<T, K>
    {
        public List<T> Keys;
        public List<K> Values;
        public int Length { get; private set; }
        public K this[T index]
        {
            get { return Values[Keys.IndexOf(index)]; }
        }
        public MyDictionary()
        {
            Length = 0;
            Keys = new List<T>();
            Values = new List<K>();
        }
        public void Add(T element1, K element2)
        {
            Keys.Add(element1);
            Values.Add(element2);
            Length++;
        }
        public IEnumerator<K> GetEnumerator()
        {
            return Values.GetEnumerator();
        }
    }
}
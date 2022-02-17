using System;
using System.Collections.Generic;

namespace Test2
{
    class MyList<T>: IMyList<T>
    {
        T[] arr; 
        public int Length { get; private set; }
        int position = -1;
        public T this[int index]
        {
            get { return arr[index]; }
        }
        public MyList()
        {
            arr = new T[0];
            Length = 0;
        }
        public void Add(T element)
        {
            T[] changedArr = new T[Length + 1];
            for (int i = 0; i < Length; i++)
            {
                changedArr[i] = arr[i];
            }
            changedArr[Length] = element;
            Length++;
            arr = changedArr;
        }
        public void Reset()
        {
            position = -1;
        }
        public IEnumerator<T> GetEnumerator()
        {
            while (true)
            {
                if (position < arr.Length - 1)
                {
                    position++;
                    yield return arr[position];
                }
                else
                {
                    Reset();
                    yield break;
                }
            }
        }
    }
}
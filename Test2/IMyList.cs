using System;

namespace Test2
{
    interface IMyList<T>
    {
        public int Length { get; }
        public void Add(T element);
    }
}

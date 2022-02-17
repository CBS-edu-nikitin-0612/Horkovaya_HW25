using System;
namespace Task3
{
    interface IMyDictionary<T, K>
    {
        public int Length { get; }
        public void Add(T element1, K element2);
    }
}

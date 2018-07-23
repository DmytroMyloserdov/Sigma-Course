using System;

namespace OwnListBasedOnArray
{
    public class OwnList<T> where T : new()
    {
        private T[] _array;
        private int _nextIndex = 0;

        public int Size
        {
            get
            {
                return _array.Length;
            }
        }

        public T this[int index]
        {
            get
            {
                return _array[index];
            }
            set
            {
                _array[index] = value;
            }
        }

        public OwnList()
        {
            _array = new T[100];
        }

        public OwnList(int size)
        {
            _array = new T[size];
        }

        public void Add(T item)
        {
            if (_array.Length == _nextIndex)
            {
                T[] temp = new T[_array.Length * 2];
                Array.Copy(_array, temp, _array.Length);
            }
            else
            {
                _array[_nextIndex] = item;
                _nextIndex++;
            }
        }
    }
}

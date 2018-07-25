using System;

namespace OwnListBasedOnArray
{
    public class OwnList<T> where T : IComparable, new()
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
                _array = temp;
            }
            _array[_nextIndex] = item;
            _nextIndex++;
        }
        public void AddRange(params T[] items)
        {
            if (_array.Length <= _nextIndex + items.Length)
            {
                T[] temp = new T[_array.Length + items.Length];
                Array.Copy(_array, temp, _array.Length);
                _array = temp;
            }
            Array.ConstrainedCopy(items, 0, _array, _nextIndex, items.Length);
            _nextIndex += items.Length;
        }
        public bool Contains(T item)
        {
            for (int i = 0; i < _nextIndex; i++)
            {
                if (_array[i].CompareTo(item) == 0) return true;
            }
            return false;
        }
        public int IndexOf(T item)
        {
            for (int i = 0; i < _nextIndex; i++)
            {
                if (_array[i].CompareTo(item) == 0)
                {
                    return i;
                }
            }
            return -1;
        }
        public int LastIndexOf(T item)
        {
            for (int i = _nextIndex - 1; i >= 0; i++)
            {
                if (_array[i].CompareTo(item) == 0)
                {
                    return i;
                }
            }
            return -1;
        }
        public T[] ToArray()
        {
            var temp = new T[_nextIndex];
            Array.ConstrainedCopy(_array, 0, temp, 0, _nextIndex);
            return temp;
        }
        public bool Remove(T item)
        {
            var index = Array.BinarySearch(_array, item);
            if (index < 0 || index >= _nextIndex)
            {
                return false;
            }
            RemoveAt(index);
            return true;
        }
        public void RemoveAt(int index)
        {
            Array.ConstrainedCopy(_array, index + 1, _array, index, _nextIndex - index);
        }
    }
}

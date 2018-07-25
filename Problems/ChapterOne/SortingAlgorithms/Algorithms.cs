using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingAlgorithms
{
    public class Algorithms<T> where T : IComparable
    {
        #region Selection Sort
        public static T[] SelectionSort(T[] input)
        {
            T[] array = new T[input.Length];
            Array.Copy(input, array, input.Length);
            int minIndex = -1;
            T minValue = default(T);
            for (int i = 0; i < array.Length; i++)
            {
                minValue = array[i];
                minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(minValue) < 0)
                    {
                        minValue = array[j];
                        minIndex = j;
                    }
                }
                array[minIndex] = array[i];
                array[i] = minValue;
            }
            
            return array;
        }
        #endregion
        #region Insertion Sort
        public static T[] InsertionSort(T[] input)
        {
            T[] array = new T[input.Length];
            Array.Copy(input, array, input.Length);
            for (int i = 1; i < array.Length; i++)
            {
                T currValue = array[i];
                int j;
                for (j = i - 1; j >= 0 && array[j].CompareTo(currValue) > 0; j--)
                {
                    array[j + 1] = array[j];
                }
                array[j + 1] = currValue;
            }
            
            return array;
        }
        #endregion
        #region Bubble Sort
        public static T[] BubbleSort(T[] input)
        {
            T[] array = new T[input.Length];
            Array.Copy(input, array, input.Length);
            for (int i = 0; i < array.Length; i++)
            {
                int j;
                bool flag = false;
                for (j = array.Length - 1; j > i; j--)
                {
                    if (array[j - 1].CompareTo(array[j]) > 0)
                    {
                        Swap(ref array, j, j - 1);
                        flag = true;
                    }
                }
                if (!flag) break;
            }
            
            return array;
        }
        #endregion
        #region Piramid Sort
        public static T[] PiramidSort(T[] input)
        {
            T[] array = new T[input.Length];
            Array.Copy(input, array, input.Length);

            BuildPiramid(ref array);
            for (int i = array.Length - 1; i > 0; i--)
            {
                var k = 0;
                Swap(ref array, i, 0);
                while (SortPiramid(ref array, ref k, i - 1)) ;
            }
            return array;
        }

        private static void BuildPiramid(ref T[] arr)
        {
            for (int i = (arr.Length - 1) / 2; i >= 0; i--)
            {
                if (SortPiramid(ref arr, ref i, arr.Length - 1)) i++;
            }
        }

        private static bool SortPiramid(ref T[] arr, ref int startIndex, int lastIndex)
        {
            int maxChild = 2 * startIndex + 1;
            if (maxChild < lastIndex && arr[maxChild].CompareTo(arr[maxChild + 1]) < 0)
            {
                maxChild++;
            }

            if (maxChild > lastIndex) return false;
            if (arr[startIndex].CompareTo(arr[maxChild]) < 0)
            {
                Swap(ref arr, startIndex, maxChild);
                if (maxChild < (lastIndex + 1) / 2)
                {
                    startIndex = maxChild;
                    return true;
                }
            }
            return false;
        }
        #endregion
        #region Merge Sort 
        public static T[] MergeSort(T[] input)
        {
            T[] array = new T[input.Length];
            Array.Copy(input, array, input.Length);

            Split(ref array, 0, array.Length - 1);

            return array;
        }

        private static void Split(ref T[] array, int startIndex, int lastIndex)
        {
            if (startIndex < lastIndex)
            {
                var middle = (lastIndex + startIndex) / 2;
                Split(ref array, startIndex, middle);
                Split(ref array, middle + 1, lastIndex);
                Merge(ref array, startIndex, middle, lastIndex);
            }
        }

        private static void Merge(ref T[] array, int start, int mid, int last)
        {
            T[] buffer = new T[last - start + 1];
            Array.ConstrainedCopy(array, start, buffer, 0, buffer.Length);
            var bufferList = buffer.ToList();
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = bufferList.Min();
                bufferList.RemoveAt(bufferList.IndexOf(buffer[i]));
            }
            Array.ConstrainedCopy(buffer, 0, array, start, buffer.Length);
        }
        #endregion
        #region Quick Sort
        public static T[] QuickSort(T[] input)
        {
            T[] array = new T[input.Length];
            Array.Copy(input, array, input.Length);
            Sort(ref array, 0, array.Length - 1);
            return array;
        }

        private static void Sort(ref T[] arr, int startIndex, int lastIndex)
        {
            if (startIndex < lastIndex)
            {
                var p = Partition(ref arr, startIndex, lastIndex);

                if (p > 1) Sort(ref arr, startIndex, p - 1);
                if (p + 1 < lastIndex) Sort(ref arr, p + 1, lastIndex);
            }
        }

        public static int Partition(ref T[] arr, int first, int last)
        {
            var p = arr[first];
            while (true)
            {
                while (arr[first].CompareTo(p) < 0) first++;
                while (arr[last].CompareTo(p) > 0) last--;

                if (arr[first].CompareTo(arr[last]) == 0) return last;
                if (first < last) Swap(ref arr, first, last);
                else return last;
            }
        }
        #endregion

        #region Utils
        public static string ToString(T[] array)
        {
            var strb = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                strb.Append(array[i] + " ");
            }
            return strb.ToString().Trim();
        }
        #endregion

        #region Private funcs
        private static void Swap(ref T[] array, int indexA, int indexB)
        {
            var temp = array[indexA];
            array[indexA] = array[indexB];
            array[indexB] = temp;
        }
        #endregion

    }
}

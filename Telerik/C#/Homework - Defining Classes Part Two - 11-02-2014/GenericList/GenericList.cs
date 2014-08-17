using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class GenericList<T>
    {
        private T[] elements;
        private int count = 0;

        public GenericList(int capacity)
        {
            this.elements = new T[capacity];
        }

        public void Add(T element)
        {
            if (count >= elements.Length)
            {
                StretchCapacity();
            }
            elements[count] = element;
            count++;
        }

        private void StretchCapacity()
        {
            T[] tempArray = new T[elements.Length * 2];
            Array.Copy(elements, 0, tempArray, 0, elements.Length);
            elements = tempArray;
        }

        public void Delete(T point)
        {
            int index = Array.IndexOf(elements, point);
            T[] tempArray = (T[])elements.Clone();
            elements = new T[tempArray.Length];
            Array.Copy(tempArray, index + 1, elements, index, elements.Length - index - 1);
            count--;
        }

        public int FindByValue(T element)
        {
            return Array.IndexOf(elements, element);
        }

        public void InsertElement(int position, T element)
        {
            if (count == elements.Length)
            {
                StretchCapacity();
            }
            Array.Copy(elements, position, elements, position + 1, elements.Length - position - 1);
            elements[position] = element;
            count++;
        }

        public void Clear()
        {
            int length;
            length = elements.Length;
            elements = new T[length];
        }

        public override string ToString()
        {
            string concatenated = string.Join(",", elements.Select(x => x.ToString()).ToArray());
            return concatenated;
        }

        public T this[int index]
        {
            get
            {
                if (index >= count)
                {
                    throw new IndexOutOfRangeException(String.Format("Invalid index: {0}.", index));
                }
                T result = elements[index];
                return result;
            }
        }
        public static T Min<T>(this GenericList<T> list)
            where T : IComparable<T>
        {
            T min = list[0];
            for (int index = 1; index < list.count; index++)
            {
                if (list[index].CompareTo(min) < 0)
                {
                    min = list[index];
                }
            }
            return min;
        }
        public static T Max<T>(this GenericList<T> list)
            where T : IComparable<T>
        {
            T max = list[0];
            for (int index = 0; index < list.count; index++)
            {
                if (list[index].CompareTo(max) > 0)
                {
                    max = list[index];
                }
            }
            return max;
        }
    }
}

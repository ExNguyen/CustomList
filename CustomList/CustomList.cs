using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        //Member Variables (HAS A)
        private T[] items;
        private int capacity;
        private int count;

        //Constructor
        public CustomList()
        {
            capacity = 4;
            count = 0;
            //An items array with a number of places equal to the capacity
            items = new T[capacity];
        }

        //Member Methods (CAN DO)
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
                return items[index];
            }
        }
        public int Count
        {
            get
            {
                return count;
            }
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }
        }

        public void Add(T item)
        {
            //'item' parameter should be added to internal 'items' array
            //if items array is at capacity, double capacity and create new array
            //transfer all items to new array
            if (count == capacity)
            {
                capacity *= 2;
                T[] newItemArray = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    newItemArray[i] = items[i];
                }
                items = newItemArray;
            }

            items[count] = item;
            count++;
        }
    

        public bool Remove(T item)
        {
            //If 'item' exists in the 'items' array, remove its first instance
            //Any items coming after the removed item should be shifted down so there is no empty index.
            //If 'item' was removed, return true. If no item was removed, return false.
            int index = -1;

            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(item))
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                for (int i = index; i < count - 1; i++)
                {
                    items[i] = items[i + 1];
                }

                items[count - 1] = default(T);
                count--;
                return true;
            }
            return false;           
        }

        public override string ToString()
        {
            //returns a single string that contains all items from array
            StringBuilder sb = new StringBuilder();
            sb.Append("");

            for (int i = 0; i < count; i++)
            {
                sb.Append(items[i]);
                if (i < count - 1)
                {
                    sb.Append(", ");
                }
            }

            sb.Append("");

            return sb.ToString();
        }

        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> that contains all items from firstList and all items from secondList 
            CustomList<T> result = new CustomList<T>();


            for (int i = 0; i < firstList.count; i++)
            {
                result.Add(firstList[i]);
            }

            for (int i = 0; i < secondList.count; i++)
            {
                result.Add(secondList[i]);
            }

            return result;
        }

        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> with all items from firstList, EXCEPT any items that also appear in secondList
            CustomList<T> result = new CustomList<T>();

            for (int i = 0; i < firstList.count; i++)
            {
                if (!secondList.Equals(firstList[i]))
                {
                    result.Add(firstList[i]);
                }
            }
            
            return result;
        }

        public CustomList<T> Zip(CustomList<T> otherList)
        {
            CustomList<T> result = new CustomList<T>();

            int minLength = Math.Min(count, otherList.Count);

            for (int i = 0; i < minLength; i++)
            {
                result.Add(this[i]);
                result.Add(otherList[i]);
            }

            for (int i = minLength; i < count; i++)
            {
                result.Add(this[i]);
            }

            for (int i = minLength; i < otherList.Count; i++)
            {
                result.Add(otherList[i]);
            }

            return result;
        }

        public void Sort()
        {
            //Instead of using the Reverse() method I created my own that should still follow the same concept
            for (int i = 0; i < count / 2; i++)
            {
                T temp = items[i];
                items[i] = items[count - 1 - i];
                items[count - 1 - i] = temp;
            }
        }

    }
}

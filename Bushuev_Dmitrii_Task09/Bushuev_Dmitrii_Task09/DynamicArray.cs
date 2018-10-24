using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Bushuev_Dmitrii_Task09
{
    class DynamicArray<T> : IEnumerable<T>
    {
        private int arraySize = 8;
        private T[] myArray;
        private int countElements = 0;

        //без параметров
        public DynamicArray()
        {
            myArray = new T[arraySize];
        }

        //с заданной длиной
        public DynamicArray(int arrayLength)
        {
            arraySize = arrayLength;
            myArray = new T[arrayLength];
        }

        //массив как параметр
        public DynamicArray(T[] inputArray) : this(inputArray.Length)
        {
            countElements = inputArray.Length;
            inputArray.CopyTo(myArray, 0);
        }

        public DynamicArray(IEnumerable<T> inputCollection )
        {
            myArray = inputCollection.ToArray();
            countElements = myArray.Length;
            arraySize = myArray.Length;
        }

        //добавить в конец массива один элемент
        public void Add(T inputElement)
        {
            Insert(inputElement, countElements);
        }

        //добавить в конец массива принятый массив
        public void AddRange(T[] inputNewArray)
        {
            int newCount = countElements + inputNewArray.Length;
            Resize(newCount);
            foreach (T i in inputNewArray)
            {
                Add(i);
            }
        }

        //удаление элемента по индексу
        public bool Remove(int index)
        {
            if (index > countElements)
            {
                return false;
            }

            T[] newArray = new T[arraySize];
            for (int i = 0, j = 0; i < myArray.Length; i++)
            {
                if (index == i)
                {
                    continue;
                }
                newArray[j++] = myArray[i];
            }
            myArray = newArray;
            countElements--;
            return true;
        }

        //добавление элемента в произвольную позицию
        public void Insert(T element, int index)
        {
            if (index > arraySize)
            {
                throw new ArgumentOutOfRangeException("Выход за пределы массива!");
            }
            Resize(countElements + 1);

            T[] newArray = new T[arraySize];
            for (int i = 0, j = 0; i < myArray.Length - 1; i++, j++)
            {
                if (index == i)
                {
                    newArray[j++] = element;
                }
                newArray[j] = myArray[i];
            }
            countElements++;
            myArray = newArray;
        }

        //число элементов списка
        public int Length => countElements;

        //получение реального объема массива
        public int Capacity => myArray.Length;

        //работа с элементом по индексу
        public T this[int index]
        {
            get
            {
                if (index > countElements)
                {
                    throw new ArgumentOutOfRangeException("Выход за пределы массива!");
                }
                return myArray[index];
            }
        }

        //Увеличение размера в два раза
        private void NextSize()
        {
            arraySize *= 2;
        }

        //Увеличение списка.
        private void Resize(int index)
        {
            if (arraySize <= index)
            {
                while (arraySize <= index)
                {
                    NextSize();
                }

                T[] newArray = new T[arraySize];
                for (int i = 0; i < myArray.Length; i++)
                {
                    newArray[i] = myArray[i];
                }
                myArray = newArray;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in myArray)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}


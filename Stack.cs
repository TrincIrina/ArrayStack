using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStack
{
    internal class Stack : Array
    {
        public int Capacity {  get; set; }      // Ёмкость массива        
        // Конструктор по умолчанию
        public Stack()
            : this(0, 0, 0) { }
        // Конструкторы с параметрами
        public Stack(int size)
            : this(size, 0, 0) { }        
        public Stack(int size, int capacity, int value)
        {
            Size = size;
            Capacity = capacity;
            data = new int[Size];
            for (int i = 0; i < Capacity; i++)
            {
                data[i] = value;
            }
            for (int i = Capacity; i < Size; i++)
            {
                data[i] = 0;
            }
        }
        // Проверка: пустой ли стэк
        public bool IsEmpty()
        {
            return Capacity == 0;
        }
        // Проверка: есть ли элемент с заданным индексом в массиве
        public override bool DataIndex(int index)
        {
            return index < Capacity;
        }
        // Метод получения элемента массива с заданным индексом
        public override int GetElem(int index)
        {
            return data[index];
        }
        // Метод установки значения в массив по заданному индексу
        public override void SetElem(int index, int value)
        {
            data[index] = value;
        }
        // добавить элемент в конец массива
        public bool AddBack(int value)
        {
            if (Capacity < Size)
            {
                data[Capacity++] = value;
                return true;
            }
            return false;
        }
        // добавить элемент в начало массива
        public void AddFront(int value)
        {
            if (IsEmpty())
            {
                data[Capacity++] = value;
            }
            else
            {
                AddIndex(0, value);
            }
        }
        // добавить элемент по индексу
        public void AddIndex(int index, int value)
        {
            if (IsEmpty())
            {
                return;
            }
            if (DataIndex(index))
            {
                if (Capacity < Size)
                {
                    int[] arr = new int[Size];
                    for (int i = 0; i < index; i++)
                        arr[i] = this.data[i];
                    arr[index] = value;
                    for (int i = index, j = index + 1; i < Capacity; i++, j++)
                        arr[j] = this.data[i];
                    Capacity++;
                    for (int i = Capacity; i < Size; i++)
                        arr[i] = 0;                    
                    data = arr;
                }
                else
                {
                    return;
                }
            }
        }
        // удалить элемент с конца массива
        public bool DeleteBack()
        {
            if (IsEmpty())
            {
                return false;
            }
            data[Capacity - 1] = 0;
            Capacity--;
            return true;
        }
        // удалить элемент с начала массива
        public void DeleteFront()
        {
            DeleteIndex(0);
        } 
        // удалить элемент по индексу
        public void DeleteIndex(int index)
        {
            if (IsEmpty())
            {
                return;
            }
            if (DataIndex(index))
            {
                int[] arr = new int[Size];
                for (int i = 0; i < index; i++)
                    arr[i] = this.data[i];
                for (int i = index + 1, j = index; i < Capacity; i++, j++)
                    arr[j] = this.data[i];
                Capacity--;
                for (int i = Capacity; i < Size; i++)
                    arr[i] = 0;
                data = arr;
            }
            else
            {
                return;

            }
        }
        // Уменьшение размера до ёмкости
        public void Shrink()
        {            
            if(Size > Capacity)
            {
                Size = Capacity;
            }
        }
        // Вывод массива в виде строки
        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < Capacity; i++)
            {
                str += Convert.ToString(data[i]) + " ";
            }
            return str;
        }
    }
}

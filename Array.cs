using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStack
{
    // Класс, описывающий массив
    internal class Array
    {
        public int Size {  get; set; }   // размер массива
        protected int[] data;            // массив
        // Конструктор по умолчанию
        public Array()
            : this(0, 0) { }
        // Конструкторы с параметрами
        public Array(int size) 
            : this(size, 0) { }
        public Array(int size, int value)
        {
            Size = size;
            data = new int[Size];
            for(int i = 0; i < Size; i++)
            {
                data[i] = value;
            }
        }
        // Проверка: есть ли элемент с заданным индексом в массиве
        public virtual bool DataIndex(int index)
        {
            return index < Size;
        }
        // Метод получения элемента массива с заданным индексом
        public virtual int GetElem(int index)
        {            
            return data[index];
        }
        // Метод установки значения в массив по заданному индексу
        public virtual void SetElem(int index, int value)
        {
            data[index] = value;
        }
        // Вывод массива в виде строки
        public override string ToString()
        {
            string str = "";
            for(int i = 0;i < Size; i++)
            {
                str += Convert.ToString(data[i]) + " ";
            }
            return str;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта класса Массив на 10 элементов
            Array array = new Array(10);
            // Рандомное заполнение массива
            Random r = new Random();
            for (int i = 0; i < array.Size; i++)
            {
                int val = r.Next(-50, 51);
                array.SetElem(i, val);
            }
            // Вывод на экран всего массива
            Console.WriteLine(array.ToString());
            // Вывод на экран элемента, стоящего по индексу - 5
            Console.WriteLine($"data[5] = {array.GetElem(5)}");
            Console.WriteLine();

            // Создание объкта класса Стэк общим размером - 15,
            // ёмкостью - 10, состоящий из элементов равных - 25
            Stack stack = new Stack(15, 10, 25);
            // Вывод стэка на экран
            Console.WriteLine(stack.ToString());
            // Добавление элемента 3 в коне стэка
            stack.AddBack(3);
            // Добавление элемента 3 в начало стэка
            stack.AddFront(3);
            // Добавление элемента 3 по индексу(5)
            stack.AddIndex(5, 3);
            // Вывод размера стэка
            Console.WriteLine($"Size = {stack.Size}");
            // Вывод ёмкости(на сколько заполнен) стэка
            Console.WriteLine($"Capacity = {stack.Capacity}");
            // Вывод стэка
            Console.WriteLine(stack.ToString());
            // Удаление элемента по индексу 5
            stack.DeleteIndex(5);
            // Удаление элемента в конце стэка
            stack.DeleteBack();            
            // Удаление элемента в начале стэка
            stack.DeleteFront();
            // Уменьшение размера до ёмкости
            stack.Shrink();
            Console.WriteLine($"Size = {stack.Size}");
            Console.WriteLine($"Capacity = {stack.Capacity}");
            Console.WriteLine(stack.ToString());            
        }
    }
}

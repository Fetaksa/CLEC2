﻿// Имеется одномерный массив array из n элементов, требуется найти элемент массива,
// равный find.

// 1. Установить счётчик index в позицию 0
// 2. Если array[index] = find, алгоритм завершил работу успешно.
// 3. Увеличить index на 1
// 4. Если index < n, то перейти к шагу 2. В противном случае, алгоритм
// завершил работу безуспешно.

//              0   1   2  3   4   5  6   7
int[] array = { 1, 12, 31, 4, 47, 68, 5, 93 };

int n = array.Length;
int find = 68;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
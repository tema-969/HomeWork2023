﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа через пробел: ");
string strnumber = Console.ReadLine();
CountNumber(strnumber);

void CountNumber (string strnumbers ){
string[] strnum = strnumber.Split(' ');
int count = 0;
foreach (var item in strnum)
{
    int num = Convert.ToInt32(item);
    if (num >0) {
        count++;
    }
}
System.Console.WriteLine("Количество чисел больше 0 = "+count);
}

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Задача 44:выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5
// --> 0 1 1 2 3
// Если N = 3
// --> 0 1 1
// Если N = 7
// --> 0 1 1 2 3 5 8

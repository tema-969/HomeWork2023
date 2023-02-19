// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


CountNumber();

void CountNumber (){
Console.WriteLine("Введите числа через пробел: ");
string strnumber = Console.ReadLine();
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
Intersection();

void Intersection (){
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine($"Пересечение в точке: ({x};{y})");
}

// Задача 44:выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5
// --> 0 1 1 2 3
// Если N = 3
// --> 0 1 1
// Если N = 7
// --> 0 1 1 2 3 5 8
Fibonachi();

void Fibonachi(){
Console.Write("Введите предел числа Фибоначи: ");
int limit = int.Parse(Console.ReadLine());
int num1 = 0;
int num2 = 1;
System.Console.Write("Ваше число Фибоначи:  0 1 ");
for (int i = 3; i <= limit; i++)
{
    int res = num1+num2;
    num1=num2;
    num2=res;

    System.Console.Write(res+ " ");
}
}
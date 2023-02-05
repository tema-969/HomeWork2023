/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.WriteLine("Введите первое число: ");
string numberOne = Console.ReadLine();
int number1 = Convert.ToInt32(numberOne);
Console.WriteLine("Введите второе число: ");
string numberTwo = Console.ReadLine();
int number2 = Convert.ToInt32(numberTwo);
if (number1 > number2)
{
    System.Console.WriteLine($"Первое число: {number1} больше.");
}
else if (number1< number2)
{
    System.Console.WriteLine($"Второе число: {number2} больше.");
}
else
{
    System.Console.WriteLine("Числа равны");
}

/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.WriteLine("Введите первое число: ");
string numberA = Console.ReadLine();
int numberA1 = Convert.ToInt32(numberA);
Console.WriteLine("Введите второе число: ");
string numberB = Console.ReadLine();
int numberB2 = Convert.ToInt32(numberB);
Console.WriteLine("Введите третье число: ");
string numberC = Console.ReadLine();
int numberC3 = Convert.ToInt32(numberC);
if (numberA1 >= numberB2 && numberA1 >= numberC3 )
{
    System.Console.WriteLine($"Число: {numberA1} наибольшее.");
}
else if (numberB2 >= numberA1 && numberB2 >= numberC3 )
{
    System.Console.WriteLine($"Число: {numberB2} наибольшее.");
}
else 
{
    System.Console.WriteLine($"Число: {numberC3} наибольшее.");
}


/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/

Console.WriteLine("Введите число: ");
string strnumber = Console.ReadLine();
int number = Convert.ToInt32(strnumber);

if (number %2 >0)
{
    System.Console.WriteLine($"Число: {number} нечетное.");
}
else if (number %2 <0)
{
    System.Console.WriteLine($"Число: {number} нечетное.");
}
else
{
    System.Console.WriteLine($"Число: {number} четное.");
}

/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.WriteLine("Введите число: ");
string userNumber = Console.ReadLine();
int variable = Convert.ToInt32(userNumber);
int a = 1;
while(a<=variable)
{
    if(a%2 == 0)
    {
        Console.Write($"{a} ");
    }
    a++;
}
Console.WriteLine();

/*End*/
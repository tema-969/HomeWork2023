/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

Console.Write ("Введите трехзначное число: ");
string strUserNumber = Console.ReadLine ();
int userNumber = Convert.ToInt32(strUserNumber);
if (userNumber<1000 && userNumber>99)
{
    System.Console.WriteLine($"Число {userNumber} трехзначное");
    int secondNumber = (userNumber/10)%10;
    System.Console.WriteLine($"Вторая цифра этого числа {secondNumber}");
}
else{
    System.Console.WriteLine("Введено неверное число");
}

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.Write ("Введите число: ");
string strUseNumber = Console.ReadLine ();
int useNumber = Convert.ToInt32(strUseNumber);
if (useNumber/100 > 0)
{
    while(useNumber>999){
        useNumber = useNumber/10;
    }
    System.Console.Write($"Третья цифра {strUseNumber} равна = ");
    int thirdNumber = useNumber%10;
    System.Console.WriteLine(thirdNumber);
}
else{
    System.Console.WriteLine("Третьей цифры в этом числе нет.");
}

/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.Write ("Введите цифру дня недели: ");
string strEnterNumber = Console.ReadLine ();
int dayNumber = Convert.ToInt32(strEnterNumber);
if (dayNumber>0 && dayNumber<6){
System.Console.WriteLine("Будний день");
}
else if (dayNumber>0 && dayNumber<8){
    System.Console.WriteLine("Выходной день");
}
else {
System.Console.WriteLine("Введено некорректное число");
}

//End Work
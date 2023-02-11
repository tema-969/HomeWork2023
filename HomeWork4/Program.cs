// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



int Exponentiation (){
System.Console.Write("Введите число: ");
int numb = int.Parse(Console.ReadLine());

System.Console.Write("Введите степень: ");
int degree = int.Parse(Console.ReadLine());

int result = numb;

if(numb !=0 && degree > 0 ) {
for (int i = 1; i < degree; i++)
{
    result = result*numb;
}

System.Console.WriteLine($"Число {numb} в степени {degree} = {result} ");

}

else {
    System.Console.WriteLine($"Число {numb} в степени {degree} = {numb} ");
}

return result;
}

//Exponentiation();

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int SumOfDigits (){

System.Console.Write("Введите число: ");
int numbUser = int.Parse(Console.ReadLine());

int sumOfDigits=0;

if (numbUser > 10 || numbUser < -10) {
    while (numbUser !=0) {
        sumOfDigits =sumOfDigits + numbUser%10;
        numbUser /=10;
    }
    System.Console.WriteLine($"Сумма цифр числа = {sumOfDigits}");
}
else {
    System.Console.WriteLine($"Сумма цифр числа = {numbUser}");
}

}

SumOfDigits();
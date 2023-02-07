/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/




/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*

System.Console.Write ("Введите координату Х для первой точки: ");
double dotXone = double.Parse(Console.ReadLine());

System.Console.Write ("Введите координату Y для первой точки: ");
double dotYone = double.Parse(Console.ReadLine());

System.Console.Write ("Введите координату Z для первой точки: ");
double dotZone = double.Parse(Console.ReadLine());

System.Console.Write ("Введите координату Х для второй точки: ");
double dotXtwo = double.Parse(Console.ReadLine());

System.Console.Write ("Введите координату Y для второй точки: ");
double dotYtwo = double.Parse(Console.ReadLine());

System.Console.Write ("Введите координату Z для второй точки: ");
double dotZtwo = double.Parse(Console.ReadLine());

double dotSQRT = Math.Pow((dotXone-dotXtwo),2)+Math.Pow((dotYone-dotYtwo),2)+Math.Pow((dotZone-dotZtwo),2);

double result = Math.Sqrt(dotSQRT);

System.Console.WriteLine(result.ToString("c2"));

/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

System.Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int i = 1;
int stepen = 3;

while(i<=number){
    ;
    System.Console.WriteLine(i+ " в степени "+  stepen+" = "+ Math.Pow(i,stepen));
    
    i++;
}


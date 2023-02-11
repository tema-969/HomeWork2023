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

Exponentiation();


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
var random = new Random();
int lenRand = random.Next(4, 10);
int[] arrThree = new int[lenRand];

FillArray(arrThree,100,1000);
PrintArray(arrThree);
System.Console.WriteLine();
CountEvenNumber(arrThree);

// void FillThreeArray (int[] numb){
//     for (int i = 0; i < numb.Length; i++)
//     {
//         numb[i] = new Random().Next(100, 1000);
//     }
// }

void PrintArray (int[] el){
    for (int i = 0; i < el.Length; i++)
    {
        System.Console.Write($"[{el[i]}] ");
    }
}

void CountEvenNumber (int[] number){
    int count = 0;
    for (int i = 0; i < number.Length; i++)
    {
        if(number[i]%2==0){
            count++;
        }
    }
    
    System.Console.WriteLine("Количество четных чисел массива" + " = " + count);
    
}

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] arr = new int[lenRand];

FillArray(arr,-100,100);
PrintArray(arr);
System.Console.WriteLine();
SumOddNumber(arr);

void FillArray (int[] numb, int minValue, int maxValue){
    for (int i = 0; i < numb.Length; i++)
    {
        numb[i] = new Random().Next(minValue, maxValue);
    }
}

void SumOddNumber (int[] number){
    int sum = 0;
    for (int i = 0; i < number.Length; i++)
    {
        if(i%2!=0){
            sum = sum + number[i];
        }
    }
    
    System.Console.WriteLine("Сумма чисел нечетных позицый массива" + " = " + sum);
    
}

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
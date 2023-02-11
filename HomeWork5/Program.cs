// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
var random = new Random();
var lenRand = random.Next(4, 10);
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

void PrintArray (int[] el){                //Метод для вывода массива в консоль
    System.Console.Write("[");
    for (int i = 0; i < el.Length; i++)
    {
        
        System.Console.Write($"{el[i]} ");
        
    }
    System.Console.Write("]");
}

void CountEvenNumber (int[] number){       //Метод поиска четных чисел массива
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

void FillArray (int[] numb, int minValue, int maxValue){    //Метод заполнения массива случайными числами
    for (int i = 0; i < numb.Length; i++)
    {
        numb[i] = new Random().Next(minValue, maxValue);
    }
}

void SumOddNumber (int[] number){                 //Метод суммы чисел в нечетных позициях массива
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

double[] arrComma = new double[lenRand];

FillArrayComa(arrComma,-10,10);
PrintArrayComma(arrComma);
System.Console.WriteLine();
Difference(arrComma);
System.Console.WriteLine("Разница между максимальным и минимальным числом массива = " +  Difference(arrComma));

void FillArrayComa (double[] mass, int min, int max){     //Метод заполнения массива вещественными числами
for (int i = 0; i < arrComma.Length; i++)
{
    arrComma[i]= Convert.ToDouble(random.Next(min,max)/10.0);
}
}

void PrintArrayComma (double[] el){             //Метод вывода вещественного массива в консоль
    System.Console.Write("[");
    for (int i = 0; i < el.Length; i++)
    {
        
        System.Console.Write($"{el[i]} ");
        
    }
    System.Console.Write("]");

}


double Difference (double[] mass){            //Метод поиска разницы max/min
double minValue=mass[0];
double maxValue=mass[0];
double result=0;
for (int i = 0; i < mass.Length; i++)
{
    if (mass[i]>maxValue) maxValue=mass[i];
    
    if (mass[i]<minValue) minValue=mass[i];
}
result = maxValue-minValue;
return result;
}  
    

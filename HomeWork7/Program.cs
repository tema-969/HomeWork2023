// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int numRows = SetNumber ("Rows");
int numCollumns = SetNumber ("Collums");
int minValue = SetNumber ("Min Value");
int maxValue = SetNumber ("Max Value");

 var matrix = GetMatrixDouble(numRows, numCollumns, minValue, maxValue);
 PrintDouble(matrix);

double[,] GetMatrixDouble(int rows, int collums, int min, int max){                //заполнение массива случайными вещественными числами
    var random = new Random();
    double [,] matrix = new double[rows, collums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < collums; j++)
        {
            matrix[i,j] = new Random().Next(min, max+1) + random.NextDouble();
        }
    }
    return matrix;
}

int SetNumber(string numberName)                                  //просим пользователя ввести число
{
Console.Write($"Enter number {numberName}: ");
int num = Convert.ToInt32(Console.ReadLine());
return num;
}

 void PrintDouble(double[,] matrix){                                    //выводим массив в консоль
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i,j] + " ");
        }
    System.Console.WriteLine();
    }
    
 }

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
var matrixIntager = GetMatrixInteger(numRows, numCollumns, minValue, maxValue);
 PrintIntager(matrixIntager);
 NumberMatrix(matrixIntager);

 void PrintIntager(int[,] matrix){                                    //выводим массив в консоль
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i,j] + " ");
        }
    System.Console.WriteLine();
    }
    
 }

int[,] GetMatrixInteger(int rows, int collums, int min, int max){          //заполняем массив случайными целыми числами
    var random = new Random();
    int [,] matrixInteger = new int[rows, collums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < collums; j++)
        {
            matrixInteger[i,j] = new Random().Next(min, max+1);
        }
    }
    return matrixInteger;
}

 int[,] NumberMatrix(int[,] matrix){                              //выводим число выбраное пользователем из матрицы в консоль
    int numRow = SetNumber("Row");
    int numCol = SetNumber("Col");
    if (numRow <= numRows && numCol <= numCollumns){
        System.Console.WriteLine(matrix[numRow-1,numCol-1]);         //сделал "-1" так как человек начинает счет не с "0" а с "1"
    }
    else{
        System.Console.WriteLine("Error");
    }
    return matrix;
 }

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

//AverageColums(matrixIntager);

double AverageColums(int[,] matrix){                                // вычисляем среднее арифметическое столбца.
    double avg = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            avg=avg + matrix[j,i];
        }
        System.Console.Write(avg/matrix.GetLength(1) + " ");
        avg=0;
    }
    return avg;
}

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}
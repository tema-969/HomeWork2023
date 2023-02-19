// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int numRows = SetNumber ("Rows");
int numCollumns = SetNumber ("Collums");
int minValue = SetNumber ("Min Value");
int maxValue = SetNumber ("Max Value");

var matrix = GetMatrix(numRows, numCollumns, minValue, maxValue);
Print(matrix);

double[,] GetMatrix(int rows, int collums, int min, int max){
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

int SetNumber(string numberName)
{
Console.Write($"Enter number {numberName}: ");
int num = Convert.ToInt32(Console.ReadLine());
return num;
}

 void Print(double[,] matrix){
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

NumberMatrix(matrix);

 double[,] NumberMatrix(double[,] matrix){
    int numRow = SetNumber("Row");
    int numCol = SetNumber("Col");
    if (numRow < numRows  + 1 && numCol <numCollumns){
        System.Console.WriteLine(matrix[numRow-1,numCol-1]);         //сделал "-1" так как человек начинает счет не с "0" а с "1"
    }
    else{
        System.Console.WriteLine("Error");
    }
    return matrix;
 }


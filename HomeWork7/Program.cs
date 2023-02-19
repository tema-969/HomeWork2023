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
    }
    System.Console.WriteLine();
 }
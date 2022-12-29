// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

Console.WriteLine("Введите кол-во строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[rows, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        matrix[i,j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        Console.Write(matrix[i,j]+" ");
        }
    Console.WriteLine();
}

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.WriteLine("Введите колличество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов 1 и строк 2: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов 2-й матрицы: ");
int b = Convert.ToInt32(Console.ReadLine());
int[,] num = new int[m, n];
for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        num[i, j] = new Random().Next(1, 10);
        Console.Write($" {num[i, j]}");
    }
    Console.WriteLine();
}
Console.WriteLine();
int[,] num2 = new int[n, b];
for (int i = 0; i < num2.GetLength(0); i++)
{
    for (int j = 0; j < num2.GetLength(1); j++)
    {
        num2[i, j] = new Random().Next(1, 10);
        Console.Write($" {num2[i, j]}");
    }
    Console.WriteLine();
}
Console.WriteLine();
int[,] num3 = new int[m, b];
for (int i = 0; i < num3.GetLength(0); i++)
{
    for (int j = 0; j < num3.GetLength(1); j++)
    {
        int sum = 0;
        for (int k = 0; k < num.GetLength(1); k++)
        {
            sum += num[i, k] * num2[k, j];
        }
        num3[i, j] = sum;
        Console.Write($" {num3[i, j]}");
    }
    Console.WriteLine();
}




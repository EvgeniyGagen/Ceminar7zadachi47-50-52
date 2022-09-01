// Задача 47. Задайте 2 ух мерный массив m=3, n=4, заполните случайными числами
using System;
Console.WriteLine("Input m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input n");
int n = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[m,n];
FillArrayRandomNumbers(matrix);
PrintArray(matrix);
void FillArrayRandomNumbers(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++);
    {
        for(int j = 0; j < array.GetLength(1); j++);
        {
            array[i,j] = Convert.ToDouble(new Random().Next(-100, 1000))/10;
        }
    }
}void PrintArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+ " ");
        }
        Console.Write("]");
    }
}
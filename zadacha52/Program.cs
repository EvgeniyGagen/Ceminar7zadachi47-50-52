// Задача 52
using System;
Console.WriteLine("Введите строки");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбцы");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m,n];
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        array[i,j] = new Random().Next(0,20);
        Console.Write(array[i,j]+ " ");
    }
    double result = 0;
    for(int j =0; j < n; j++)
    {
        result = Average(j);
        Console.WriteLine("Среднее арифм каждого столбца: "+ result);
    }
    double Average(int column)
    {
        double average = 0;
        double x = 0;
        for(int i = 0; i < m; i++)
        {
            average += array[i,column];
        }
        x = average / m;
        return x;

    }
}

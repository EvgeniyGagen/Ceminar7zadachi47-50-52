using System;
// Console.WriteLine("Input m");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input n");
// int n = Convert.ToInt32(Console.ReadLine());

double [,] matrix = 
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
    {5, 2, 6, 7}

};
for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.WriteLine($" {matrix[i,j]}");
        Console.WriteLine();
    }
Console.WriteLine();
}
double sum = 0;
for(int i = 0; i < matrix.GetLength(0); i++)
{
    sum = Sum(i);
    Console.WriteLine($" {sum}");
}
double Sum (int stroka)
{
    double summa = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        summa += matrix[stroka,i];
    }
    return summa;
}

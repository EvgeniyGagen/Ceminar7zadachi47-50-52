using System;
Console.WriteLine("Input m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input n");
int n = Convert.ToInt32(Console.ReadLine());

double [,] matrix = 
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},

};
for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        
        Console.Write($" {matrix[i,j]}");
        
    }
Console.WriteLine();
}

void PrintArray(double[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        Console.Write($" {matr[i,j]}");
    }
}
void SelectionSort (double[,] matr)
{
    for(int i = 0; i < matr.GetLength(0) - 1; i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
        int minPosition = i;
        for(int k = i + 1; k < matr.GetLength(0); k++)
        {
            if(matr[k,j] < matr[minPosition,j]) minPosition = k;
        }
        double temporary = matr[i,j];
        matr[i,j] = matr[minPosition,j];
        matr[minPosition,j] = temporary;
        }
    }
}
PrintArray(matrix);
 SelectionSort(matrix);
 
 PrintArray(matrix);
 
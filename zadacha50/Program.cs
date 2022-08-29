using System;
Console.WriteLine("Введите размеры массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [m,n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i,j] = new Random().Next (10, 100);
        Console.Write (array[i,j] +"\t  ");
    }
    Console.WriteLine();
}

Console.WriteLine ("Введитt элемент: ");
int row = Convert.ToInt32 (Console.ReadLine());
int a = 999;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if(array[i,j] == row)
        {
            a = array[i,j];
            break;
        }
    }
}
if(a != 999)
{
    Console.WriteLine("такое число есть");
}else{
    Console.WriteLine("такое число не существует");
}


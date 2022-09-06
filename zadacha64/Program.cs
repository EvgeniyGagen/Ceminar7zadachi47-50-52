//Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> ""1, 2, 3, 4, 5""
//M = 4; N = 8. -> ""4, 6, 7, 8""

int M;
int N;

Console.Write("Введи M: ");
 M = Convert.ToInt16(Console.ReadLine());
Console.Write("Введи N: ");
 N = Convert.ToInt16(Console.ReadLine());


if (N>M)
    for (int i = M; i <= N; i++)
    {
    Console.Write($" {i}");
    }

else
    for (int i = N; i <= M; i++)
    {
      Console.Write($" {i}");
    }
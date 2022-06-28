using System;
using static System.Console;
Clear();

Write("Введите число строк массива: ");
int m = int.Parse(ReadLine());
Write("Введите число столбцов массива: ");
int n = int.Parse(ReadLine());
int[,] array = FillArrayMPlusN(m, n);
PrintArray(array);


int[,] FillArrayMPlusN(int rows, int len)
{
    int[,] array1 = new int[rows, len];
    for(int i = 0; i < array1.GetLength(0); i++)
    {
        for(int j = 0; j < array1.GetLength(1); j++)
        {
            array1[i, j]= i + j;
        }
    }
    return array1;
}

void PrintArray(int[,] array1)
{
    for(int i = 0; i < array1.GetLength(0); i++)
    {
        for(int j = 0; j < array1.GetLength(1); j++)
        {
            Write($"{array1[i,j]} ");            
        }
        WriteLine();
    }    
}
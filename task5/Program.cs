using System;
using static System.Console;
Clear();

Write("Введите число строк массива: ");
int m = int.Parse(ReadLine());
Write("Введите число столбцов массива: ");
int n = int.Parse(ReadLine());
int[,] array = GetRandomArray(m, n);
PrintArray(array);
WriteLine($"{SumDigArray(array)}");


int[,] GetRandomArray(int row, int column)
{
    int[,] result = new int[row,column];
    for(int i = 0; i < result.GetLength(0); i++)
    {
        for(int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j]= new Random().Next(0,10);
        }
    }
    return result;
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

int SumDigArray(int[,] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.GetLength(0);i++)
    {
        sum += arr[i,i];        
    }
    return sum;
}
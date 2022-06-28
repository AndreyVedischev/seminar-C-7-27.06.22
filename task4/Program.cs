using System;
using static System.Console;
Clear();

int[] array = { 1, 2, 3, 4, 5 };
int max = array[0];
int min = array[0];

foreach (int r in array)
{
    max = max < r ? r : max;
    min = min > r ? r : min;
}

WriteLine($"{min} {max}");



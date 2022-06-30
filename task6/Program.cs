using System;
using static System.Console;
using System.Linq;
Clear();

// WriteLine("Введите массив через пробел: ");

// int[] array = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
// .Select(x => int.Parse(x)).Where(x => x % 2 == 0).ToArray();
// WriteLine(String.Join(",", array));

// int array = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
// .Select(x => int.Parse(x)).Count(x => x % 2 == 0);
// WriteLine(array);

// WriteLine("Введите длинну массива: ");

// int t = int.Parse(ReadLine());
// int[] array = new int[t].Select(x => x = new Random().Next(-10,10)).ToArray();
//  WriteLine(String.Join(",", array));

WriteLine("Введите массив через пробел: ");

int[] array = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
.Select(x => int.Parse(x)).OrderBy(x => x).ToArray();
WriteLine(String.Join(",", array));
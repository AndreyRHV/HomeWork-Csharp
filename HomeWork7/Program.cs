/// Task 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/// m = 3, n = 4.
/// 0,5 7 -2 -0,2
/// 1 -3,3 8 -9,9
/// 8 7,8 -7,1 9


// double[,] GenerateArray(int rows, int columns){
//     double[,] array = new double[rows, columns];
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToDouble(rnd.Next(-100, 100)/10.0);
//         }
//     }
//     return array;
// }

// void PrintArray(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write($"{matrix[i, j]}\t");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// double[,] myArray = GenerateArray(3, 4);
// PrintArray(myArray);



// /// Task 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// /// и возвращает значение этого элемента или же указание, что такого элемента нет.
// /// Например, задан массив:
// /// 1 4 7 2
// /// 5 9 2 3
// /// 8 4 2 4
// /// 1,7 -> такого числа в массиве нет

// int[,] GenerateArray(int rows, int columns, int minRnd, int maxRnd)
// {
//     int[,] array = new int[rows, columns];
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = rnd.Next(minRnd, maxRnd);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write($"{matrix[i, j]}\t");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// int Promt(string message)
// {
//     System.Console.Write(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return (result);
// }

// void FindDigitOnArray(int[,] array, int row, int column)
// {
//     int number = 0;
//     if (row < array.GetLength(0) && column < array.GetLength(1))
//     {
//         System.Console.WriteLine(array[row, column]);
//     }
//     else
//     {
//         System.Console.WriteLine($"{row},{column} -> такого числа в массиве нет.");
//     }

// }

// int[,] newArray = GenerateArray(3, 4, 0, 10);
// PrintArray(newArray);
// int row = Promt("Введите индекс строки:  ");
// int column = Promt("Введите индекс столбца: ");
// FindDigitOnArray(newArray, row, column);

// /// Task 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// /// Например, задан массив:
// /// 1 4 7 2
// /// 5 9 2 3
// /// 8 4 2 4
// /// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// int[,] GenerateArray(int rows, int columns, int minRnd, int maxRnd)
// {
//     int[,] array = new int[rows, columns];
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = rnd.Next(minRnd, maxRnd);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write($"{matrix[i, j]}\t");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// void AverageColumn(int[,] array)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         double sum = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             sum += array[i, j];
//         }
//         Console.Write($"{Math.Round((sum / array.GetLength(0)), 2)};  ");
//     }
// }

// int[,] myArray = GenerateArray(3, 4, 0, 10);
// PrintArray(myArray);
// AverageColumn(myArray);
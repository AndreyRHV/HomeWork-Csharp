/// Task 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/// Например, задан массив:
/// 1 4 7 2
/// 5 9 2 3
/// 8 4 2 4
/// В итоге получается вот такой массив:
/// 7 4 2 1
/// 9 5 3 2
/// 8 4 4 2

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

// void PrintArrayMatrix(int[,] matrix)
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

// int[,] SortDescending(int[,] array)
// {
//     int temp = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
//     return array;
// }

// int[,] newArray = GenerateArray(3, 4, 0, 10);
// PrintArrayMatrix(newArray);
// SortDescending(newArray);
// PrintArrayMatrix(newArray);




/// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/// Например, задан массив:
/// 1 4 7 2
/// 5 9 2 3
/// 8 4 2 4
/// 5 2 6 7
/// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

// void PrintArrayMatrix(int[,] matrix)
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

// void SumLinesMin(int[,] array)
// {
//     int minSum = Int32.MaxValue;
//     int indexLine = 0;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum = sum + array[i, j];
//         }
//         if (sum < minSum)
//         {
//             minSum = sum;
//             indexLine = i;
//         }
//     }

//     Console.WriteLine($"Наименьшая сумма элементов в {indexLine} строке.");

// }

// int[,] newArray = GenerateArray(3, 4, 0, 10);
// PrintArrayMatrix(newArray);
// SumLinesMin(newArray);




/// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/// Например, даны 2 матрицы:
/// 2 4 | 3 4
/// 3 2 | 3 3
/// Результирующая матрица будет:
/// 18 20
/// 15 18


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

// void PrintArrayMatrix(int[,] matrix)
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

// int[,] MultiplicationMatrix(int[,] array1, int[,] array2)
// {
//     int [,] MatrixAB = new int [array1.GetLength(0), array2.GetLength(1)];
//     for (int i = 0; i < array1.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2.GetLength(1); j++)
//         {
//             for (int k = 0; k < array1.GetLength(1); k++)
//             {
//                 MatrixAB[i, j] += (array1[i, k] * array2[k, j]);
//             }
//         }
//     }
//     return MatrixAB;
// }

// int[,] MatrixA = GenerateArray(2, 2, 0, 10);
// PrintArrayMatrix(MatrixA);
// int[,] MatrixB = GenerateArray(2, 2, 0, 10);
// PrintArrayMatrix(MatrixB);
// PrintArrayMatrix(MultiplicationMatrix(MatrixA, MatrixB));






/// Task 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
/// которая будет построчно выводить массив, добавляя индексы каждого элемента.
/// Массив размером 2 x 2 x 2
/// 66(0,0,0) 25(0,1,0)
/// 34(1,0,0) 41(1,1,0)
/// 27(0,0,1) 90(0,1,1)
/// 26(1,0,1) 55(1,1,1)



int[,,] GenerateArray(int axisX, int axisY, int axisZ, int minRnd, int maxRnd)
{
    int[,,] array = new int[axisX, axisY, axisZ];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = rnd.Next(minRnd, maxRnd);
            }
            
        }
    }
    return array;
}

void PrintCoordinatesNumbers(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
               System.Console.Write($"{matrix[i, j, k]}({i}, {j}, {k})\t"); 
            }
            
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,,] newArray = GenerateArray(2, 2, 2, 10, 100);
PrintCoordinatesNumbers(newArray);

/// Task 62. Напишите программу, которая заполнит спирально массив 4 на 4.
/// Например, на выходе получается вот такой массив:
/// 01 02 03 04
/// 12 13 14 05
/// 11 16 15 06
/// 10 09 08 07

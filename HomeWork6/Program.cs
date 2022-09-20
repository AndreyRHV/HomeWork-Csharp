// //// Task 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// //// 0, 7, 8, -2, -2 -> 2
// //// 1, -7, 567, 89, 223-> 3

// int Promt(string message)
// {
//     System.Console.Write(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// int[] GenerateArray(int length) {
//     var array = new int[length];

//     for (var i = 0; i < array.Length; i++)
//     {
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write($"{arr[i]}\t");
//     }
//     System.Console.WriteLine();
// }

// int CountPositiveNumbers(int[] array){
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 0){
//             count++;
//         }
//     }
//     return count;
// }

// int len = Promt("Введите длину массива: ");
// int[] arr1 = GenerateArray(len);
// PrintArray(arr1);
// System.Console.WriteLine(CountPositiveNumbers(arr1));

// /// Task 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// /// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// /// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.Write("Введите b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());


// if (k1 == k2 && b1 == b2)
// {
//     System.Console.WriteLine("Прямые совпадают");
// }
// else if (k1 == k2)
// {
//     System.Console.WriteLine("Параллельные прямые");
// }
// else
// {
//     double x = (b2 - b1)/(k1 - k2);
//     double y = k1 * x + b1;
//     Console.WriteLine($"Точка пересечения:({x}; {y})");
// }


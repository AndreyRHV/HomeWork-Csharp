// /// Task 25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


// Console.Write("Введите число a: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число b: ");
// int b = Convert.ToInt32(Console.ReadLine());

// int Exponentiation(int numberA, int numberB){
//   int res = 1;
//   for(int i=1; i <= numberB; i++){
//     res = res * numberA;
//   }
    
//     return res;
// }
// System.Console.WriteLine(Exponentiation(a, b));


// Console.Write("Введите число a: ");
// int a = Convert.ToInt32(Console.ReadLine());

// /// Task 27 Напишите программу. которая принимает на вход число и выдает сумму цифр в числе.

//  Console.Write("Введите чило: ");
// int n = Convert.ToInt32(Console.ReadLine());


// int SumDigits (int number){
//     int sum = 0;
//     while (number > 0){
//         sum = sum + number % 10;
//         number /= 10;
//     }
//     return sum;
// }

// System.Console.WriteLine(SumDigits(n));

// /// Task 29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]


// int [] GetArray(){
//     int[] res = new int[8];
//     for (int i = 0; i < res.Length; i++)
//     {
//         res[i] = new Random().Next(1, 100);
        
//     }
//     return res;
// }

// void PrintArray(int[] arr){
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.WriteLine(arr[i]);
        
//     }
// }

// PrintArray(GetArray());
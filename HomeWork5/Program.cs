// /// Task 34 Задайте массив заполненный случайными положительными трёхзначными числами. 
// /// Напишите программу, которая покажет количество чётных чисел в массиве.
// /// [345, 897, 568, 234] -> 2

// int[] GenerateArray(int length) {
//     var array = new int[length];
//     var random = new Random();

//     for (var i = 0; i < array.Length; i++){
//         array[i] = random.Next(100, 1000);
//     }

//     return array;
// }

// void PrintArray(int[] array) {
//     for (var i = 0; i < array.Length - 1; i++){
//         Console.Write(array[i] + ", ");
//     }
//     Console.WriteLine(array[array.Length - 1]);
// }

// int countEvenNumbers(int[] array){
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//         count++;
        
//     }
//     return count;
// }
// var array = GenerateArray(7);
// PrintArray(array);
// System.Console.WriteLine(countEvenNumbers(array));



// /// Task 36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// /// [3, 7, 23, 12] -> 19
// /// [-4, -6, 89, 6] -> 0

// int[] GenerateArray(int length) {
//     var array = new int[length];
//     var random = new Random();

//     for (var i = 0; i < array.Length; i++) {
//         array[i] = random.Next(10, 100);
//     }

//     return array;
// }

// void PrintArray(int[] array) {
//     for (var i = 0; i < array.Length - 1; i++) {
//         Console.Write(array[i] + ", ");
//     }
//     Console.WriteLine(array[array.Length - 1]);
// }

// int SumNumbersOddPos(int[] array) {
//     int sum = 0;

//     for (int i = 0; i < array.Length; i++) {
//        if (i % 2 != 0) 
//        sum += array[i];
//     }
//     return sum;
// }

// var array = GenerateArray(8);
// PrintArray(array);
// System.Console.WriteLine(SumNumbersOddPos(array));



// /// Task 38 Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// /// [3 7 22 2 78] -> 76


// float[] GenerateArray(int length) {
//     var array = new float[length];
//     var random = new Random();

//     for (var i = 0; i < array.Length; i++) {
//         array[i] = random.NextSingle() * 10;
//     }

//     return array;
// }

// void PrintArray(float[] array) {
//     for (var i = 0; i < array.Length - 1; i++) {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine(array[array.Length - 1]);
// }

// float diffMaxMinNumbers(float[] array) {
//     float max = array[0];
//     float min = array[0];
    
//     for (int i = 0; i < array.Length; i++) {
//        if (array[i] > max) 
//        max = array[i];
//        else {
//         min = array[i];
//        }
       
//     }
//     return array.Max() - array.Min();
// }

// var array = GenerateArray(4);
// PrintArray(array);
// Console.WriteLine(diffMaxMinNumbers(array));

System.Console.WriteLine("b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());


double IntersectionPoint(double b1, double k1, double b2, double k2){
   double x = (b2 -b1) / (k2 - k1);
   double y = k1 * x + b1;
    
    if (k1 == k2 && b1 == b2)
    System.Console.WriteLine("pryamie sovpadaut");

    else if (k1 == k2){
    System.Console.WriteLine("pryamie");
    
    return 0;
    }
}

System.Console.WriteLine(IntersectionPoint);
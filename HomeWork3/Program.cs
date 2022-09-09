////// Task 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно 
///// палиндромом. 12321 -> да

// System.Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// if (n / 10000 == n % 10 && n / 1000 % 10 == n % 100 / 10){
//     System.Console.WriteLine($"{n} -> палиндром");
// }

// else{
//     System.Console.WriteLine($"{n} -> не палиндром");
// }



///// Task21  Напишите программу, которая принимает на вход координаты двух точек и находит расстояние
///// между ними в 3D пространстве.

// System.Console.Write("Введите координату по x точки A: ");
// int xa = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите координату по y точки A: ");
// int ya = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите координату по z точки A: ");
// int za = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите координату по x точки B: ");
// int xb = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите координату по y точки B: ");
// int yb = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите координату по z точки B: ");
// int zb = Convert.ToInt32(Console.ReadLine());

// double result = Math.Sqrt(Math.Pow((xb - xa),2) + Math.Pow((yb - ya),2) + Math.Pow((zb - za),2));
// System.Console.WriteLine(result);


///// Task23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

// System.Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// for (int a = 1; a <= n; a++){
//     System.Console.WriteLine(a * a * a);
// }
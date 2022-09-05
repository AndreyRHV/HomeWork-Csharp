// //Task10

// int n = new Random().Next(100, 1000);

// int result =  n % 100 / 10;

// System.Console.WriteLine($"{n} -> {result}");


// //Task13

// Console.WriteLine("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = a % 1000 / 100;
// if (a > 99){
  
//     System.Console.WriteLine($"{a} -> {b}");
// }
// else{
//     System.Console.WriteLine("Третьей цифры нет.");
// }


//Task15

Console.WriteLine("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day >= 1 && day <= 5){
    System.Console.WriteLine("Рабочий день недели.");
}
else if (day == 6 || day == 7){
    System.Console.WriteLine("Выходной день недели.");
}
else{
    System.Console.WriteLine("Такого дня недели нет.");
}
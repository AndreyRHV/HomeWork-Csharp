/// Task 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
/// Выполнить с помощью рекурсии.
/// N = 5 -> "5, 4, 3, 2, 1"
/// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// int Prompt(string message)
// {
//     System.Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void ShowNumbers(int number)
// {
//     if (number <= 0)
//     {
//         return;
//     }
//     System.Console.WriteLine(number);
//     ShowNumbers(number - 1);
// }

// int number = Prompt("Введите номер >");
// ShowNumbers(number);






/// Task 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/// M = 1; N = 15 -> 120
/// M = 4; N = 8. -> 30


// int Prompt(string message)
// {
//     System.Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int SumNumbers(int numberM, int numberN)
// {
//     int sum = 0;
//     if (numberM > numberN)
//     {
//         return 0;
//     }
//     sum = numberM + SumNumbers(numberM + 1, numberN);

//     return sum;

// }


// int numberM = Prompt("Введите значение M: ");
// int numberN = Prompt("Введите значение N: ");
// System.Console.WriteLine($"Сумма цифр от {numberM} до {numberN} -> {SumNumbers(numberM, numberN)}");





/// Task 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/// m = 2, n = 3 -> A(m,n) = 9
/// m = 3, n = 2 -> A(m,n) = 29



int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int AckermanFunction(int numberM, int numberN)
{
    if (numberM == 0)
    {
        return numberN + 1;
    }
    else if (numberN == 0 && numberM > 0)
    {
        return AckermanFunction(numberM - 1, 1);
    }
    return AckermanFunction(numberM - 1, AckermanFunction(numberM, numberN - 1));

}

int numberM = Prompt("Введите значение M: ");
int numberN = Prompt("Введите значение N: ");
System.Console.WriteLine($"A({numberM},{numberN}) -> {AckermanFunction(numberM, numberN)}");
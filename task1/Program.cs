﻿// Задание 1. Совместная работа
// Напишите программу, которая на вход принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 * number1 == number2)
    {
        Console.WriteLine($"Число {number2} является квадратом числа {number1}");
    }

else if (number1 == number2 * number2)
    {
       Console.WriteLine($"Число {number1} является квадратом числа {number2}"); 
    }

    else
    {
        Console.WriteLine("Не является");
    }
    
Console.WriteLine(Convert.ToInt32(Math.Pow(number1, 2)));



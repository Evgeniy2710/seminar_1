﻿using System;

public class Answer {
    static void PrintEvenNumbers(int number)
    {
      // Введите свое решение ниже

int counter = 1;
while (counter <= number)
    {
        if (counter %2 == 0)
        Console.Write($" {counter} " );
         counter++;
    }

    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 63;
        }

        // Не удаляйте строки ниже
        PrintEvenNumbers(number);
    }
}
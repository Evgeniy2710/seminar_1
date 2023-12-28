Не все тесты пройдены, есть ошибки :(


Количество затраченных попыток: 2

Время выполнения: 2.044908 сек

Общая статистика
Всего тестов: 2. Пройдено: 0. Не пройдено: 2.

Подробную информацию по каждому тесту смотрите ниже.

Тест 1
Тест не пройден ✗

Формулировка:

* Аргументы, передаваемые в метод/функцию:


number: '5'


* Итоговый код для проверки. Иногда добавляем что-то от себя :)


using System;

public class Answer {
    static void PrintEvenNumbers(int number)
    {
      // Введите свое решение ниже
int counter = 1;
while (counter <= number)
    {
        if (counter %2 == 0)
        Console.Write($" {counter}\t" );
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
            number = 5;
        }

        // Не удаляйте строки ниже
        PrintEvenNumbers(number);
    }
} // Проверяем решение


Ожидаемый ответ:

2	4

Ваш ответ:

2	 4
Тест 2
Тест не пройден ✗

Формулировка:

* Аргументы, передаваемые в метод/функцию:


number: '8'


* Итоговый код для проверки. Иногда добавляем что-то от себя :)


using System;

public class Answer {
    static void PrintEvenNumbers(int number)
    {
      // Введите свое решение ниже
int counter = 1;
while (counter <= number)
    {
        if (counter %2 == 0)
        Console.Write($" {counter}\t" );
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
            number = 5;
        }

        // Не удаляйте строки ниже
        PrintEvenNumbers(number);
    }
} // Проверяем решение


Ожидаемый ответ:

2	4	6	8

Ваш ответ:

2	 4	 6	 8

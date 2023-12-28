// Задание 2. Совместная работа
// Напишите программу, которая на вход принимает целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры:
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2


Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
if(num < 0)
{
    num = num * (-1);
}
int counter = - num;
while (counter <= num)
    {
        Console.Write($" {counter} " );
        counter++;
    }

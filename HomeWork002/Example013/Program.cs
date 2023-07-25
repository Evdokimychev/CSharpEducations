/* Задача 13. Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.

Пример:
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.Clear();

// int num = new Random().Next(1, 1000);

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine() ?? "");

int a1 = num / 100;
int a2 = num / 10 % 10;
int a3 = num % 10;
int result = a1 * 10 + a3;
if (num / 100 == 0) Console.WriteLine($"{num}: -> третьей цифры нет");
else Console.WriteLine($"{num}: -> {a3}");

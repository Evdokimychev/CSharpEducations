// Задача 2: Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.

// Пример: 
// a = 5; b = 7 ->  max = 7
// a = 2; b = 10 -> max = 10

// Организация ввода данных
Console.Write("Введите целое число a: ");
int number1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите целое число b: ");
int number2 = int.Parse(Console.ReadLine() ?? "");

// Логика вычеслений
int max = 0;
if (number1 > number2) max = number1;
else max = number2;

// Метод 3 (интерполяция) - вывод данных
Console.WriteLine($"a = {number1}, b = {number2} -> max = {max}");
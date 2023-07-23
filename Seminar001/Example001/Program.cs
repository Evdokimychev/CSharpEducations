// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3, b = 9 -> нет

// Организация ввода данных
Console.Write("Введите целое число A: ");
int number = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите целое число B: ");
int number2 = int.Parse(Console.ReadLine() ?? "");

// Логика вычеслений
string result = "";
if (number == number2 * number2) result = "да";
else result = "нет";

// Метод 1
// Console.Write(number);
// Console.Write(" -> ");
// Console.WriteLine(result);

// Метод 2 
// Console.WriteLine(number + " -> " + result);

// Метод 3 (интерполяция) - вывод данных
Console.WriteLine($"a = {number}, b = {number2} -> {result}");
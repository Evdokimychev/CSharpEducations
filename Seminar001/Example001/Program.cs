// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 

// Организация ввода данных
Console.Write("Введите целое число A: ");
int number1 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите целое число B: ");
int number2 = int.Parse(Console.ReadLine() ?? "");

// Логика вычеслений
string result = "";
if (number1 == number2 * number2) result = "да";
else result = "нет";

// Метод 3 (интерполяция) - вывод данных
Console.WriteLine($"a = {number1}, b = {number2} -> {result}");
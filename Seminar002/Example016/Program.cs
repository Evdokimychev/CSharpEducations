// Задача 16. Напишите программу, которая принимает на вход два числа 
// и проверяет, является ли одно число квадратом другого.

// Пример:
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.Clear();

// Организация ввода данных
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine() ?? "");


// Вычесления
int result1 = num1 / num2;
int result2 = num2 / num1;

if (result1 == num2 || result2 == num1) 
    Console.WriteLine($"Число {num1} и число {num2} ->  да");
else 
    Console.WriteLine($"Число {num1} и число {num2} ->  нет");
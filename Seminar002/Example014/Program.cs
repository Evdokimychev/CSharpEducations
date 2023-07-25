// Задача 14. Напишите программу, которая принимает на вход число 
// и проверяет, кратно ли оно одновременно 7 и 23.

// Пример:
// 14 -> нет 
// 161 -> да

Console.Clear();

// Организация ввода данных
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine() ?? "");

// Вычесления

int result = num % 7;
int result2 = num % 23;

if (result == 0 && result2 == 0) 
    Console.WriteLine($"Число {num} одновременно кратно 7 и 23");
else 
    Console.WriteLine($"Число {num} не кратно 7 и 23");
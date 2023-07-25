// Задача 12. Напишите программу, которая будет принимать на вход два числа 
// и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// Пример: 
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.Clear();

// Организация ввода данных
Console.Write("Введите первое число: ");
string userInput = Console.ReadLine() ?? "";
int num1 = int.Parse(userInput);

Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine() ?? "");

// Вычесления

// Тоже рабочий код - мой вариант
// string result1 = "";
// if (num1 % num2 == 0) result1 = "кратно";
// else result1 = "не кратно";

// int result2 = num1 % num2;
// Console.WriteLine($"Число {num1} {result1} {num2}: -> остаток {result2}");

int result = num1 % num2;
if (result == 0) 
    Console.WriteLine($"Число {num1} кратно {num2}");
else 
    Console.WriteLine($"Число {num1} не кратно {num2} -> остаток {result}");
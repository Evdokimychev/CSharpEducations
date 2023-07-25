/* Задача 15. Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

Пример:
6 -> да
7 -> да
1 -> нет */

Console.Write("Введите номер дня недели: ");
int numberDay = int.Parse(Console.ReadLine() ?? "");


// Логика вычеслений
string result = "такого дня недели нет";
if (numberDay == 1) result = "Понедельник - будний день";
else if (numberDay == 2) result = "Вторник - будний день";
else if (numberDay == 3) result = "Среда - будний день";
else if (numberDay == 4) result = "Четверг - будний день";
else if (numberDay == 5) result = "Пятница - будний день";
else if (numberDay == 6) result = "Суббота - выходной";
else if (numberDay == 7) result = "Воскресение - выходной";

// Метод 3 (интерполяция) - вывод данных
Console.WriteLine($"День {numberDay} -> {result}");
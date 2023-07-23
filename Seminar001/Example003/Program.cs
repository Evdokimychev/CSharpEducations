// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

// Организация ввода данных
Console.Write("Введите номер дня недели: ");
int numberDay = int.Parse(Console.ReadLine() ?? "");

// Данные в программе из базы данных
// string day1 = "Понедельник";
// string day2 = "Вторник";
// string day3 = "Среда";
// string day4 = "Четверг";
// string day5 = "Пятница";
// string day6 = "Суббота";
// string day7 = "Воскресение";

// int numberDay1 = 1;
// int numberDay2 = 2;
// int numberDay3 = 3;
// int numberDay4 = 4;
// int numberDay5 = 5;
// int numberDay6 = 6;
// int numberDay7 = 7;

// numberDay1 = day1;
// numberDay2 = day2;
// numberDay3 = day3;
// numberDay4 = day4;
// numberDay5 = day5;
// numberDay6 = day6;
// numberDay7 = day7;

// Логика вычеслений
string result = "такого дня недели нет";
if (numberDay == 1) result = "Понедельник";
if (numberDay == 2) result = "Вторник";
if (numberDay == 3) result = "Среда";
if (numberDay == 4) result = "Четверг";
if (numberDay == 5) result = "Пятница";
if (numberDay == 6) result = "Суббота";
if (numberDay == 7) result = "Воскресение";

// Метод 3 (интерполяция) - вывод данных
Console.WriteLine($"День {numberDay} -> {result}");


﻿// Задача 11. Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.

// Пример: 
// 456 -> 46
// 782 -> 72

Console.Clear();

int num = new Random().Next(100, 1000);
int a1 = num / 100;
int a3 = num % 10;

// Console.WriteLine($"Новое число полученное из {num}: -> {a1}{a3}");

int result = a1 * 10 + a3;

Console.WriteLine($"Новое число полученное из {num}: -> {result}");
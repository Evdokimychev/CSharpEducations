// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

// Пример: 
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78


// Организация ввода данных
Console.Write("Введите целое число a: ");
int number1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите целое число b: ");
int number2 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите целое число c: ");
int number3 = int.Parse(Console.ReadLine() ?? "");

// Логика вычеслений
int max = 0;
if (number1 > number2) max = number1;
    else if (number2 > number3) max = number2;
    else max = number3;

// Метод 3 (интерполяция) - вывод данных
Console.WriteLine($"{number1}, {number2}, {number3} -> {max}");
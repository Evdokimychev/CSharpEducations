// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

// Организация ввода данных
Console.Write("Введите целое число: ");
// string userInput = Console.ReadLine() ?? "";
// int number = int.Parse(userInput);
int number = int.Parse(Console.ReadLine() ?? "");

// Логика вычеслений
int result = number * number;

// Метод 1
// Console.Write(number);
// Console.Write(" -> ");
// Console.WriteLine(result);

// Метод 2 
// Console.WriteLine(number + " -> " + result);

// Метод 3 (интерполяция) - вывод данных
Console.WriteLine($"{number} -> {result}");

// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// Пример: 
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


// Организация ввода данных
Console.Write("Введите целое число больше 0: ");
int number = int.Parse(Console.ReadLine() ?? "");

// Логика вычеслений
if (number <= 0)
    {
    Console.WriteLine("Введено неверное число");
    return;
    }

Console.Write($"{number} -> ");

int count = 2;
while (count <= number)
{
    Console.Write($"{count} ");
    count = count + 2;
}
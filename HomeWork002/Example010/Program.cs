/* Задача 10. Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

Пример:
456 -> 5
782 -> 8
918 -> 1 */

Console.Clear();

string s;
int number;

Console.Write("Введите трёхзначное число: ");
s = Console.ReadLine() ?? "";

while (!int.TryParse(s, out number) || (number < 100 || number >=1000)) 
{
    System.Console.WriteLine("Это не трехзначное число");
    Console.Write("Введите трёхзначное число: ");
    // number = int.Parse(Console.ReadLine() ?? "");
    s = Console.ReadLine() ?? "";
}
int mid = (number / 10 % 10);
    System.Console.WriteLine($"{number} -> {mid}");
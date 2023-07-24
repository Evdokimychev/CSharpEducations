// 7. Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

// Организация ввода данных
Console.Write("Введите целое трёхзначное: ");
int number = int.Parse(Console.ReadLine() ?? "");

// Логика вычеслений
if (number >=100 && number <1000)
{
    int mid = (number % 10);
    System.Console.WriteLine($"{number} -> {mid}");
}
else
    System.Console.WriteLine("Это число не трехзначное");

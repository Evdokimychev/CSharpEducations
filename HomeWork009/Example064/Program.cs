/* Задача 64: 
Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 5; N = 1. -> "5, 4, 3, 2, 1"
M = 8; N = 4. -> "8, 7,6, 5, 4".
 */

Main();

(int, int) GetBorders()
{
    int mFrom = 0, nTill = 0;
    Console.WriteLine("Введите числа М и N, между которыми необходимо вывести числа.");
    Console.Write("Введите число М: ");
    mFrom = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число N: ");
    nTill = Convert.ToInt32(Console.ReadLine());
    return (mFrom, nTill);
}

void PrintNumberRow(int mFrom, int nTill)
{
    if (mFrom == nTill)
    {
        Console.WriteLine("{0}.", mFrom);
    }
    else
    {
        Console.Write("{0}, ", mFrom);
        PrintNumberRow(mFrom-1, nTill);
    }
}

void Main()
{
    int numberFrom = 0, numberTill = 0;
    (numberFrom, numberTill) = GetBorders();
        if (numberFrom > numberTill)
            PrintNumberRow(numberFrom, numberTill);
        else if (numberFrom < numberTill)
            PrintNumberRow(numberTill, numberFrom);
}

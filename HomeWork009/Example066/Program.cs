/* Задача 66: 
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Main();

(int, int) GetNumbers()
{
    int mFrom =0,  nTill =0;
    Console.WriteLine("Введите числа М и N, между которыми найдем сумму натуральных элементов.");
    Console.Write("Введите число М: "); 
    mFrom = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число N: "); 
    nTill = Convert.ToInt32(Console.ReadLine());
    return (mFrom, nTill);
}

int NumberSum(int mFrom, int nTill)
{
    int result = nTill;
    if (mFrom == nTill) return mFrom;
    return result + NumberSum(mFrom,nTill-1);
}

void Main ()
{
    int numberFrom = 0, numberTill =0;
    int sumResult = 0; 
    (numberFrom, numberTill) = GetNumbers();
    sumResult = NumberSum(numberFrom, numberTill);
    Console.WriteLine("\nСумма натуральных чисел между {0} и {1} = {2}.", numberFrom, numberTill, sumResult);
}
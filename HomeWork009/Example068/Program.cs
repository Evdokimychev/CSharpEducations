/* Задача 68: 
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9 */

Main();

(int, int) GetNumbers()
{
    int mNumber = 0, nNumber = 0;
    do
    {
        Console.Clear();
        Console.WriteLine("Введите числа m и n для функции Аккермана.");
        Console.Write("Введите число m: ");
        mNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число n: ");
        nNumber = Convert.ToInt32(Console.ReadLine());
        if (mNumber < 0 || nNumber < 0)
        {
            Console.WriteLine("Ошибка! Один из аргументов меньше 0!");
            Console.ReadKey();
        }
        if (mNumber > 4 && nNumber > 1)
        {
            Console.WriteLine("При m = {0} и n = {1} получается очень большое число.",
                                mNumber, nNumber);
            Console.ReadKey();
        }
        else break;
    } while (true);
    return (mNumber, nNumber);
 }

int CountAkkerman(int m, int n)
{
    // Console.WriteLine("m = {0} и n = {1} ", m, n);
    if (m == 0) return ++n;
    if (n == 0 && m > 0) return CountAkkerman(m - 1, 1);
    if (m > 0 && n > 0) return CountAkkerman(m - 1, CountAkkerman(m, n - 1));
    else return -1;
}

void Main()
{
    int mArgument = 0, nArgument = 0;
    int result = 0;
    (mArgument, nArgument) = GetNumbers();
    result = CountAkkerman(mArgument, nArgument);
    if (result < 1) 
        Console.WriteLine("Ошибка!");

    Console.WriteLine("При m = {0} и n = {1} функция Аккермана A(m,n) = {2}  .", mArgument, nArgument, result);
}

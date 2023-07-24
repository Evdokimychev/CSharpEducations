int[] array = {1, 12, 31, 4, 18, 15, 16, 17, 18};

int n = array.Length; // Определяем количество элементов в массиве

// Организация ввода данных
Console.Write("Введите целое число: ");
int find = int.Parse(Console.ReadLine() ?? "");

// Логика решения
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine ($"Это элемент под номером: {index}");
        break;
    }
    index++; // index = index + 1
}

// Console.WriteLine ($"Этот элемент не найден");
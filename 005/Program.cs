// Найти сумму чисел одномерного массива стоящих на нечетной позиции
Console.Clear();
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
int[] array = new int[size];

for (int i = 0; i < size; i++)
    array[i] = new Random().Next(1, 10);

Console.WriteLine($"Ваш массив ");

for (int i = 0; i < size; i++)
    Console.Write($"{array[i]} ");

int sum = 0;
for (int i = 1; i < size; i += 2)
{
    sum = sum + array[i];
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Сумма чисел одномерного массива стоящих на нечетной позиции равна {sum}");
Console.WriteLine();
// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
Console.Clear();

int size = 10;
int[] array = new int[size];

for (int i = 0; i < size; i++)
    array[i] = new Random().Next(1, 10);
Console.WriteLine($"Ваш массив ");

for (int i = 0; i < size; i++)
    Console.Write($"{array[i]} ");

int max = array[0];
int min = array[0];

for (int i = 0; i < size; i++)
{
    if ( array[i] > max) max = array[i];
    else
    if (array[i] < min) min = array[i];
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Максимальное значение равно {max}, минимальное хзначение равно {min}");
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементом равна {max - min}");
Console.WriteLine();
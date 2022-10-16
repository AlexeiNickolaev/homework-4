// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
int[] array = new int[12];
int sumPlus = 0;
int sumMinus = 0;

for (int i = 0; i < 12; i++)
    array[i] = new Random().Next(0, 10);
Console.WriteLine($"Ваш массив ");


for (int i = 0; i < 12; i++)
{
    Console.Write($"{array[i]}");

    if (array[i] >= 0)
        sumPlus = array[i] + sumPlus;
    else
        sumMinus = array[i] + sumMinus;
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Сумма положительных чисел массива равна {sumPlus}");
Console.WriteLine();
Console.WriteLine($"Сумма отрицательных чисел массива равна {sumMinus}");
Console.WriteLine();
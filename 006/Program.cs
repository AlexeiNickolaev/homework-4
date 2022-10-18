// Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.

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


int[] mas = new int[(size + 1) / 2];
for (int i = 0; i < mas.Length; i++)

    mas[i] = array[i] * array[size - i - 1];
Console.WriteLine();
Console.WriteLine($"Произведение пар первого и последнего элемента, второго и предпоследнего и т.д. равно: ");

for (int i = 0; i < mas.Length; i++)
    Console.Write($"{mas[i]} ");
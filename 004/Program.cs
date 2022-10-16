// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
Console.Clear();
int[] array = new int[123];

for (int i = 0; i < 123; i++)
    array[i] = new Random().Next(0, 500);

Console.WriteLine($"Ваш массив ");

for (int i = 0; i < 123; i++)
    Console.Write($"{array[i]} ");

int count = 0;
for (int i = 0; i < 123; i++)
{
    if ((array[i] >= 10) && (array[i] <= 99)) 
    count++;
}    
Console.WriteLine();
Console.WriteLine();  
Console.WriteLine($"В данном массиве количество элементов из отрезка [10,99] встречается {count} раз");
Console.WriteLine();
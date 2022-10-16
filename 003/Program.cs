// Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел
Console.Clear();
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
int [] array = new int [size];
int chet = 0;
int nechet = 0;

for(int i = 0; i < size; i++)
     array [i]= new Random().Next(100,  1000);

Console.WriteLine($"Ваш массив ");

for(int i = 0; i < size; i++)

Console.Write($"{array[i]} ");

for(int i = 0; i < size; i++)

     if (array[i] % 2 == 0) chet =chet + 1;
     else  nechet =nechet + 1;

Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве: {chet} ");
Console.WriteLine();
Console.WriteLine($"Количество нечетных чисел в массиве: {nechet} ");
Console.WriteLine();  



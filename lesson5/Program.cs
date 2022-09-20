//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
ArrayUser(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
int count = 0;

for (int z = 0; z < numbers.Length; z++)
if (numbers[z] % 2 == 0)
count++;

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

void ArrayUser(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Введите размер массива");
int size2 = Convert.ToInt32(Console.ReadLine());
int[] numbers2 = new int[size2];
FillArrayRandomNumbers(numbers2);
Console.WriteLine("Вот наш массив: ");
PrintArray2(numbers2);
int sum = 0;

for (int z = 0; z < numbers2.Length; z+=2)
    sum = sum + numbers2[z];

    Console.WriteLine($"всего {numbers2.Length} чисел, сумма элементов на нечётных позициях = {sum}");

void FillArrayRandomNumbers(int[] numbers2)
{
    for(int i = 0; i < numbers2.Length; i++)
        {
            numbers2[i] = new Random().Next(1,10);
        }
}
void PrintArray2(int[] numbers2)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers2.Length; i++)
        {
            Console.Write(numbers2[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите размер массива");
int size3 = Convert.ToInt32(Console.ReadLine());
double[] numbers3 = new double[size3];
FillArrayRandomNumbers3(numbers3);
Console.WriteLine("Вот наш массив: ");
PrintArray3(numbers3);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < numbers3.Length; z++)
{
    if (numbers3[z] > max)
        {
            max = numbers3[z];
        }
    if (numbers3[z] < min)
        {
            min = numbers3[z];
        }
}

Console.WriteLine($"всего {numbers3.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers3(double[] numbers3)
{
    for(int i = 0; i < numbers3.Length; i++)
        {
            numbers3[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray3(double[] numbers3)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers3.Length; i++)
        {
            Console.Write(numbers3[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
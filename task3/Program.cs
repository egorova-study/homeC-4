// Задача 29: Напишите программу, которая задаёт массив из 8 элементов, заполненный 
// псевдослучайными числами и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33] 

Console.Write("массив из восьми случайных элементов от 1 до 99: ");

int[] array = new int[8]; // массив из 8 элементов
GetArray(array); // вызвали метод
PrintArray(array); // вывод массива

void GetArray(int[] arr)
{
    int length = arr.Length;
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(1, 100); // каждому эл-ту массива присвоили значение от 1 до 99
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
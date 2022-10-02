// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа");
int degree = Convert.ToInt32(Console.ReadLine());

if (degree > 0)
{
    int SumNumbers(int num)
    {
        int result = number;
        while (degree > 1)
        {
            number = result * number;
            degree--;

        }
        return number;
    }
    int sumResult = SumNumbers(number);


    Console.Write($"результат возведения в степень = {number}");
}

else if (degree == 0) Console.Write($"результат возведения в степень = 1");

else Console.Write("степень не может быть меньше нуля");
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите целое число для рассчета суммы его цифр");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0; 
if (num > 9)
{
    while (num > 0)
    {
        sum = num % 10 + sum;
        num = num / 10;
    }

    Console.Write($"сумма цифр в числе = {sum}");
}

else if (num < 0) Console.Write("введите положительное число");
else Console.Write("число состоит из одного знака, нет смысла считать сумму");
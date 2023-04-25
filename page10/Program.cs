// Принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите число: ");
int count = Convert.ToInt32(Console.ReadLine());


void SecondNumber(int number)
{
    if (number > 100 && number < 1000)
    {
        int a = number / 10;
        int b = a % 10;
        Console.WriteLine(b);
    }
    else
    {
        Console.WriteLine("Введите трехзначтное число");
    }
}

SecondNumber(count);
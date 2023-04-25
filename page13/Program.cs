//  Выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.WriteLine("Введите число: ");
int count = Convert.ToInt32(Console.ReadLine());


void UselessProgram (int number)
{
    int a = number%10;
    if (number > 99 && number < 1000)
    {
        Console.WriteLine(a);
    }
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        Console.WriteLine("Введите трехзначтное число");
    }
}


UselessProgram (count);
//  Принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


Console.WriteLine("Введите число: ");
int WeekDay = Convert.ToInt32(Console.ReadLine());


void UselessProgram (int count)
{
    if (count>0 && count <6)
    {
        Console.WriteLine("Рабочий день");
    }
    else
    {
        Console.WriteLine("Выходной день");
    }
}


UselessProgram(WeekDay);


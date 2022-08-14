Console.WriteLine("Введите номер дня недели");
int a = Convert.ToInt32(Console.ReadLine());

if ( a <= 7 && a >= 1)
{
    if (a == 6 || a == 7)
    {
        Console.WriteLine("Выходной день.");
    }
    else
    {
        Console.WriteLine("Будний день.");
    }
}
else 
{
    Console.WriteLine("Нет такого дня.");
}





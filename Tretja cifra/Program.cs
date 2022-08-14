Console.WriteLine("введите число из трех цифр");
int a = Convert.ToInt32(Console.ReadLine());
string str = a.ToString();
int[] b = new int[str.Length];
for( int i=0; i< str.Length; i++)
{
    b[i] = int.Parse(str[i].ToString());
}

void PrintArray(int[] b)
{
     int count = b.Length; 
     int position = 0;
     while(position < count)
     {
         Console.WriteLine(b[2]);
         break;
     }
}

if (b.Length == 3)
{
    Console.Write("Третья цифра числа - ");
    PrintArray(b);
    Console.WriteLine();
}
if (b.Length > 3)
{
    Console.Write("Ошибка! Вы ввели больше трех цифр.");
}
if (b.Length < 3)
{
    Console.Write("Третьей цифры нет!");
}
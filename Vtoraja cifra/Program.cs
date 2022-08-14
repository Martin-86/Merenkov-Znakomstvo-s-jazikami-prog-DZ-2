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
         Console.WriteLine(b[1]);
         break;
     }
}

Console.Write("Вторая цифра числа - ");
PrintArray(b);
Console.WriteLine();

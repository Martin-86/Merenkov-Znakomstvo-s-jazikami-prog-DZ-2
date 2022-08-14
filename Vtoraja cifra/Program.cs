Console.WriteLine("введите число из трех цифр");
int a = Convert.ToInt32(Console.ReadLine());
string str = a.ToString();           // Скажите, пожалуйста, почему ToString() используется 2 раза? 1 раз здесь.
int[] b = new int[str.Length];
for( int i=0; i< str.Length; i++)
{
    b[i] = int.Parse(str[i].ToString()); // Второй раз здесь. str[i].ToString() объект из string опять преобразовавают в string?
} // И объясните пожалуйста словами, что происходит в строке 7?

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

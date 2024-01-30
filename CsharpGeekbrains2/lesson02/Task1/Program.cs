/*
int[] array = new int[] {1, 5, 34, 76, 43, 14, 67 };
int target = 14;

bool flag = false;

foreach (int elem in array)
{ 
     if(elem == target)
     {
        flag = true;
     }
     if (flag == true)
     {
        Console.WriteLine("Yes");
     }
     else
     {
        Console.WriteLine("No");
     }
}
*/

/*
int[] array = new int[] {-1, 6, -34, 67, -80, -8, 15 };

for(int i = 0; i < array.Length; i++)
{
    array[i] *= -1;   // сокращенное умножение
}

Console.Write($"{array[i]} , " );
*/




internal class Programm
{
    private static void Main(string[] args)
    {
        //Домашняя Задача1
        int[] array = new int[] { 1, 5, 10, 20, 30, 40, 99, 4, 90, 3 };
        int m = 0;
        Console.Write("Для массива ");
        foreach (int elem in array)
        {
            if (elem >= 10 & elem <= 90)
            {
                m++;
            }
            Console.Write($"{elem} ");
        }
        g
Console.WriteLine();
        Console.WriteLine($"Количество элементов лежащих в диапазоне от 20 до 90: {m}");
    }
}
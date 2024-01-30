using System;
Random random = new Random();
int[] mass = new int[10];
int counter = 0;
    for(int i = 0;i<mass.Length; i++){
    mass[i] = random.Next(100, 1000);
        if(mass[i] % 2 == 0){
            counter++;
        }
Console.Write($"{mass[i]} ");
}
Console.WriteLine();
Console.WriteLine($"Количество четных чисел {counter} ");
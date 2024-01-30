int[] mass = new int[]{1,3,5,6,7,8};

Console.WriteLine("Исходный массив");
Console.WriteLine(string.Join(" ", mass));
int d2=mass.Length/2;
for(int i=0;i<=d2;i++){
    int t = mass[i];
    mass[i]=mass[mass.Length-1-i];
    mass[mass.Length-1-i]=t;
}
Console.WriteLine("Перевернутый массив");
Console.WriteLine(string.Join(" ", mass));



/*int[] mass=new int[]{1,3,5,6,7,8};
int[] rev_mass=new int[mass.Length];
int j=mass.Length-1;
for(int i=0;i<mass.Length;i++){
    rev_mass[j]=mass[i];
    j--;
}
Console.WriteLine("Исходный массив");
foreach(int elem in mass){
Console.Write($"{elem} ");
}
Console.WriteLine();
Console.WriteLine("Перевернутый массив");
foreach(int elem in rev_mass){
Console.Write($"{elem} ");
}*/


//Вариант 2
/*int[] mass = new int[]{1,3,5,6,7,8};

Console.WriteLine("Исходный массив");
foreach(int elem in mass){
Console.Write($"{elem} ");
}
Console.WriteLine();

int d2=mass.Length/2;
for(int i=0;i<=d2;i++){
    int t = mass[i];
    mass[i]=mass[mass.Length-1-i];
    mass[mass.Length-1-i]=t;
}
Console.WriteLine("Перевернутый массив");
foreach(int elem in mass){
    Console.Write($"{elem} ");
}
*/
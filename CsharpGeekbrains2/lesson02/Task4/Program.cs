/*
int num = 96352;
string str_num = num.ToString(); 
char[] charArray = str_num.ToCharArray();
int [] intArray=new int[charArray.Length];
for(int i=0;i<charArray.Length;i++){
    intArray[i]=(int)Char.GetNumericValue(charArray[i]); 
}
Console.WriteLine($"Массив из числа {num}");
foreach(int elem in intArray){
    Console.Write($"{elem} ");
}
int[] reverseArray = new int[intArray.Length];
int j = 0;
for(int i = intArray.Length -1;i >= 0; i--){
    reverseArray[j] = intArray[i];
    j++;
}
Console.WriteLine();
Console.WriteLine($"Reverse массив из числа {num} ");
foreach(int elem in reverseArray){
    Console.Write($"{elem} ");

}
*/

Console.Write("Введите натуральное число N: ");
        
       
    
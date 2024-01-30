// Домашняя задача 2
/*
int[] array = new int[] {2, 5, 2, 3, 6, 3, 7, 8, 2, 4};
Console.Write($"Четные числа");
int  check = 0;
foreach(int elem in array){
    if ((elem % 2) == 0){
Console.Write($" {elem} ");
        check++;
    }
}
Console.WriteLine();
Console.WriteLine($"Количество четных элементов {check} ");
*/


// Доп занятия, 1 задача
/*
Console.WriteLine("Введите число");
string num = Console.ReadLine();
int number = int.Parse(num); 
for(int i = 1; i<= number; i++){
    if((number % i) == 0){
        Console.Write($" {i} ");
    }

}
*/

// Доп занятия, 2 задача
/*
Console.WriteLine("Введите число");
string num = Console.ReadLine();
int sum = 0;
int number = int.Parse(num); 
for(int i = 1; i<= number; i++){
    sum += i;
}
Console.Write($" {sum} ");
*/

// Доп занятия, 3 задача
/*
Console.WriteLine("Введите число");
string num = Console.ReadLine();
double number = int.Parse(num); 
for(int i = 1; i<= number; i++){
    double squareRoot = Math.Sqrt(i);
    if(squareRoot % 5 == 0){
Console.WriteLine(i);
    }
}
*/

// Доп занятия, 4 задача
/*
Console.WriteLine("Введите число");
string num = Console.ReadLine();
double number = int.Parse(num); 
for(int i = 1; i<= number; i++){
    if((Math.Pow(i,2) % Math.Sqrt(i)) ==0){
Console.WriteLine(i); 
    }
}
*/


// Доп занятия, 5 задача
/*
Console.WriteLine("Введите число");
string num = Console.ReadLine();
int number = int.Parse(num); 
int q = 0;
int sum_del = 0; 
Console.WriteLine($"делители числа {number}");
for(int i = 1; i<= number; i++){
    if((number % i) == 0){
        Console.Write($"  {i} ");
        q++;
        sum_del += i;
    }

}
Console.WriteLine();
Console.WriteLine($"Количество делителей {q} \nСумма делителей {sum_del}");
   */

// Доп занятия, 7 задача
/*
string num;
int number;
while(true) {
Console.WriteLine("Введите число"); 
num = Console.ReadLine();
number = int.Parse(num);   
    if(number > 2) {
        break; // выход с цикла while
    }
    else{
        Console.WriteLine("Введите число больше 5");
    }
} 
int ariv = 0; 
int geom = 1;
for(int i = 1;i<=number;i++){
    ariv+=i;
    geom*=i;
}
double A = ariv / number;
double G = geom / number;

Console.WriteLine(Math.Round(A/G,4));

*/


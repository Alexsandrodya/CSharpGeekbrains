void Req(int m, int n){
    if(m <= n){
        Console.WriteLine(m);
        Req(m+1,n);
    }
}
Console.Write("Введите натуральное число m:");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите натуральное число n:");
int n = int.Parse(Console.ReadLine());
Req(m,n);

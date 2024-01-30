// 1 Домашняя задача: 
void Func(){    
Console.Write("ВВедите число: ");    
string? str = Console.ReadLine()?? ""; 
    if (str == "q"){
        Console.WriteLine("Выход из программы");
        return;
    }
int num = int.Parse(str);
int counter = 0;
    while(num > 0){
        counter += num % 10;
        num = num / 10;
    }
    if (counter % 2 == 0){
        Console.WriteLine("Число четное, выход из программы");
        return;
    }
    else{
       Func(); 
    }
}
Func();












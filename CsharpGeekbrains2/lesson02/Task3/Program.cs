double[] array = new double[] {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01};
double num_max = 0;
double num_min = array[0];
foreach(double elem in array){
    if(elem < num_min){
        num_min = elem;

    }
    if(elem > num_max){
        num_max = elem;
    }
}
Console.WriteLine();
Console.WriteLine($" Максимальное значение {num_max},\n Минимальное значение {num_min},\n Разность {num_max - num_min} ");

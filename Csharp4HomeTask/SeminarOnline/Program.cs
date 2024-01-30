int[,] matrix = {
    {1, 3, 4, 5},
    {2 ,4, 7, 8},
    {10, 14, 11, 12}
};
void PrintTable(int[,] table){
    for(){
        Console.WriteLine(e + " ");
    }
}
void ReplaseElemBySquares(int[,] table){   //int strs, int colums не нужны..
    for(int i = 0; i< table.GetLength(0); i++){ // GetLength(0) - число столбцов
      for(int j = 0; j< table.GetLength(1); j++){ // GetLength(1) - число строк
        if(i % 2 == 0 && j % 2 == 0){
            table[i, j] *= table[i , j];
        }
      }
    }
}
PrintTable(matrix);
ReplaseElemBySquares(matrix);
PrintTable(matrix);
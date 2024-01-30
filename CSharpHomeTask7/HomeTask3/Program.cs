int[] array = new int[10] {10, 5, 12, 1, 55, 40, 9, 8, 85, 42};
void function(int[] array){
    if(array.Length != 0){
        Console.Write($"{array[array.Length - 1]} ");
        Array.Resize(ref array, array.Length - 1);
        function(array);
    }
}
function(array);

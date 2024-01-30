void GetConsonants(string str){
string consonants = "bcdfghjklmnpqrstvwxyz";                        
    if(str.Length != 0){
        char s = str[0];
        s = char.ToLower(s);
        if(consonants.Contains(s)){
            Console.Write($"{str[0]} ");
        }
GetConsonants(str.Substring(1));
    }
}
string str = Console.ReadLine();
GetConsonants(str); 
Console.Clear();
Console.Write("Enter the array elements with spaces: ");
string input = Console.ReadLine()!;
Console.Write("Enter the number of symbols, that the elements you want to find, consist of: ");
int num = int.Parse(Console.ReadLine()!);

string[] array = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine($"[{string.Join(" ", SeveralSymbolElements1(array, num))}]");
Console.WriteLine($"[{string.Join(" ", SeveralSymbolElements2(array, num))}]");

string[] SeveralSymbolElements1(string[] inArray, int number){
    string result = string.Empty;
    for (int i = 0; i < inArray.Length; i++)
    {
        if(inArray[i].Length <= number) result += inArray[i] + " ";
    }
    return result.Split(" ", StringSplitOptions.RemoveEmptyEntries);
}

string[] SeveralSymbolElements2(string[] inArray, int number){
    int count = 0;
    for (int i = 0; i < inArray.Length; i++){
        if (inArray[i].Length <= number) count++;
    }
    string[] result = new string[count];
    for (int i = 0, j = 0; i < inArray.Length; i++){
        if (inArray[i].Length <= number){
            result[j] = inArray[i];
            j++;
        }
    }
    return result;
}
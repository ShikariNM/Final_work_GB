Console.Clear();

// Получаем входные данные от пользователя. Добавил переменную количества символов,
// из которых состоят искомые элементы. По условию задачи  num = 3.

Console.Write("Enter the array elements with spaces: ");
string input = Console.ReadLine()!;
Console.Write("Enter the number of symbols, that the elements you want to find, consist of: ");
int num = int.Parse(Console.ReadLine()!);

// Преобразуем входную строку в массив, который является объектом, данным по условию задачи

string[] array = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

// Три метода решения задачи. Хотя в условии задачи рекомендовано избегать использования
// коллекций, решил, что, в качестве дополнительного метода, можно.

Console.WriteLine($"[{string.Join(" ", SeveralSymbolElements1(array, num))}]");
Console.WriteLine($"[{string.Join(" ", SeveralSymbolElements2(array, num))}]");
Console.WriteLine($"[{string.Join(" ", SeveralSymbolElements3(array, num))}]");


string[] SeveralSymbolElements1(string[] inArray, int number){
    string result = string.Empty;
    foreach (var element in inArray){
        if(element.Length <= number) result += element + " ";
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

string[] SeveralSymbolElements3(string[] inArray, int number){
    List<string> temp = new List<string>();
    foreach (var element in inArray){
        if (element.Length <= number) temp.Add(element);
    }
    string[] result = new string[temp.Count];
    temp.CopyTo(result);
    return result;
}
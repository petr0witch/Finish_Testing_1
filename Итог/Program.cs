//Промежуточное тестирование

string[] a = {"hello", "2", "world", ":-)"};
string[] b = {"1234", "1567", "-2", "computer science"};
string[] c = {"Russia", "Denmark", "Kazan"};

string[] GetBackArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < string[3]) return array; 
    }
    return array;
}

void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

PrintArray(GetBackArray(a));
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("]");
}
int CollectNumberOfString(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length<=3) count++;
    }
    return count;
}

string[] CreateArrayOfStringWith3OrLessChar(string[] array, int number)
{
    string[] result=new string[number];
    int counter=0;
    for(int i=0;i<array.Length;i++)
    {
        if(array[i].Length<=3)
        {
          result[counter]=array[i];
          counter++;
        }
    }
    return result;
}




string[] array = { ":)", "Earth", "человек", "432", "дуб","Io" };
Console.Write("Исходный массив: ");
PrintArray(array);
Console.Write("Массив с 3 и меньше символами: ");
string[] result=CreateArrayOfStringWith3OrLessChar(array,CollectNumberOfString(array));
PrintArray(result);
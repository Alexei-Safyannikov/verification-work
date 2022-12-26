string[] ArrayString(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i} индекс массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}
void PrintArrayString(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"‟{array[i]}‟,");
        else Console.Write($"‟{array[i]}‟");
    }
    Console.Write("]");
}
string[] NewArrayString(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    string[] newArray = new string[count];
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[k] = array[i];
            k++;
        }
    }
    return newArray;
}
Console.Write("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
if (size <= 0) Console.WriteLine("Ошибка");
else
{
    string[] array = ArrayString(size);
    PrintArrayString(array);
    string[] newArray = NewArrayString(array);
    Console.WriteLine();
    PrintArrayString(newArray);
}
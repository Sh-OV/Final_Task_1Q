// Условия итоговой задачи за 1 четверть читай в файле README.md
Console.Clear();
string[] UserArray()                    // метод получения строкового массива от пользователя
{
    Console.Write("Введите количество элементов строкового массива: ");
    int count = Convert.ToInt32(Console.ReadLine());
    string[] userarray = new string[count];
    Console.WriteLine($"Введите {count} элементов текста (через Enter): ");
    for (int i = 0; i < userarray.Length; i++)
    {
        userarray[i] = Console.ReadLine();
    }
    return userarray;
}
string[] uarray = UserArray();
Console.WriteLine();
PrintArr(uarray);
Console.Write("  ->  ");

string[] SelectArray(string[] array)        // метод выбора элементов входного массива по условию (путем создания нового массива)
{
    int quantity = 3;
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    string[] selectarray = new string[count];
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= quantity)
        {
            selectarray[k] = array[i];
            k++;
        }
    }
    if (count == 0) Console.WriteLine("[]");
    return selectarray;
}
string[] sarray = SelectArray(uarray);

void PrintArr(string[] res)  // метод вывода строкового одномерного массива на печать
{
    for (int i = 0; i < res.Length; i++)
    {
        if (i == 0) Console.Write($"[");
        if (i < res.Length - 1) Console.Write($"{res[i]}, ");
        else Console.Write($"{res[i]}]");
    }
}
PrintArr(sarray);
Console.WriteLine();
Console.WriteLine();

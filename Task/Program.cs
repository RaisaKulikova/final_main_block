void Main()
{
    Console.Write("Введите количество строк в массиве: ");
    int n = Convert.ToInt32(Console.ReadLine());
    string[] FirstArray = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write("Введите строку №{0}:\r\n    ", i + 1);
        FirstArray[i] = Console.ReadLine()!;
    }
    int count = CountThreeAndLess(FirstArray);
    string[] SecondArray = new string[count];
    ArrayThreeAndLess(FirstArray, SecondArray);
    PrintArray(SecondArray);
}
int CountThreeAndLess(string[] array1)
{
    int count = 0;
    foreach (string i in array1)
    {
        if (i.Length <= 3 && i.Length > 0)
        {
            count++;
        }
    }
    return count;
}
void ArrayThreeAndLess(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3 && array1[i].Length > 0)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}
Main();

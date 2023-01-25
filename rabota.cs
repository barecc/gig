Console.Clear();
string[] array1 = {"123", "23", "da", "net", "hz"};
string[] array2 = array1.Where(x => x.Length <= 3).ToArray();
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(array2);
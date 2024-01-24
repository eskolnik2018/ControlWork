string[] array1 = new string[5] { "hey", "12", "well", "hello", "wor" };
string[] arrey2 = new string[array1.Length];

void FinalArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            arrey2[count] = array1[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
FinalArray(array1, arrey2);
PrintArray(arrey2);

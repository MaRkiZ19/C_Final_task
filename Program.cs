
int ArrayLenght()
{
    System.Console.Write("Enter the desired number of lines: ");
    int len = Convert.ToInt32(Console.ReadLine());
    return len;
}

void FillingArray(int len, string[] array1)
{
    for (int i = 0; i < len; i++)
            {
                Console.Write("Enter the string №{0}:\r\n    ", i + 1);
                array1[i] = Console.ReadLine(); 
            }
}

void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
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

int len = ArrayLenght();
// string[] array1 = new string[] {"Hello", "2", "world", ":-)"};
string[] array1 = new string[len];
string[] array2 = new string[array1.Length];
FillingArray(len, array1);
PrintArray(array1);
SecondArrayWithIF(array1, array2);
PrintArray(array2);

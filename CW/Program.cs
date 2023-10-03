/* Написать программу, которая из имеющегося массива строк формирует 
новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
выполнения алгоритма. При решении не рекомендуется пользоваться 
коллекциями, лучше обойтись исключительно массивами. */

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

string[] CreateArray(int size)
{
    string[] newArr = new string[size];
    return newArr;
}

void FillArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Введите элемент массива " + i + ": ");
        arr[i] = Console.ReadLine()!;
    }
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

string[] CreateThreeCharArray(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
       if (arr[i].Length <= 3)
            count++;
    }

    string[] result = new string[count];
    count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
       if (arr[i].Length <= 3)
       {
            result[count] = arr[i];
            count++;
       }
    }

    return result;
}

int size = InputNum("Введите размер массива: ");
string[] array = CreateArray(size);
FillArray(array);
System.Console.WriteLine();
PrintArray(array);
System.Console.WriteLine();
string[] resultArray = CreateThreeCharArray(array);
PrintArray(resultArray);

/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.*/
int inputNumber(string str)
{
    int number;
    string text;
    while (true)
    {
        System.Console.WriteLine(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("не удалось распознать число");

    }
    return number;
}

Console.Clear();
int m = inputNumber("Введите значение m");
int n = inputNumber("Введите значение n");
int[,] arr = new int[5, 5];
FillArrayWithRandomNumbers(arr);

if (n > arr.GetLength(0) || m > arr.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {arr[n-1,m-1]}");
}

void FillArrayWithRandomNumbers(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Convert.ToInt32(new Random().Next(-100, 100));
            System.Console.Write(arr[i, j] + " ");
        }
        System.Console.WriteLine();
    }   
}

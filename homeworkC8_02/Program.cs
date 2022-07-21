// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}
int[,] GenerateArray(int rows, int columns, int min, int max)
{
    int[,] answers = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            answers[i, j] = rnd.Next(min, max + 1);
        }
    }
    return answers;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
    }
    System.Console.WriteLine();
}
void MinSumm(int[,] array)
{
    int summ = 0;
    int index = 0;
    int minsum = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        if (sum < minsum)
        {
            minsum = sum;
        }
        index++;
    }
    Console.WriteLine($"строка:{index}, с суммой элементов:{minsum}");
    return;
}
int rows = Prompt("Введите количество строк: ");
int columns = Prompt("Введите количество столбцов: ");
int[,] myArray = GenerateArray(rows, columns, -10, 10);
PrintArray(myArray);
System.Console.WriteLine();
MinSumm(myArray);
System.Console.WriteLine(MinSumm);
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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
void Arrange(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int n = 0; n < array.GetLength(1) - 1; n++)
            {
                if (array[i, n] < array[i, n + 1]) 
                {
                    int temp = 0;
                    temp = array[i, n];
                    array[i, n] = array[i, n + 1];
                    array[i, n + 1] = temp;
                }
            }
        }
    }
}
int rows = Prompt("Введите количество строк: ");
int columns = Prompt("Введите количество столбцов: ");
int[,] myArray = GenerateArray(rows, columns, -10, 10);
PrintArray(myArray);
System.Console.WriteLine();
Arrange(myArray);
PrintArray(myArray);
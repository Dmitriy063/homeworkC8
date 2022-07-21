// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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
void MatrixMult(int[,] array1, int[,] array2, int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                sum += array1[i, k] * array2[k, j];
            }
            array[i, j] = sum;
        }
    }
}
int rows1 = Prompt("Введите количество строк 1-ой матрицы: ");
int columns1 = Prompt("Введите количество столбцов 1 -ой матрицы: ");
int[,] myArray1 = GenerateArray(rows1, columns1, -10, 10);
PrintArray(myArray1);
System.Console.WriteLine();
int rows2 = Prompt("Введите количество строк 2-ой матрицы: ");
int columns2 = Prompt("Введите количество столбцов 2-ой матрицы: ");
int[,] myArray2 = GenerateArray(rows2, columns2, -10, 10);
PrintArray(myArray2);
System.Console.WriteLine();
int[,] myArray = new int[rows1,columns2];
MatrixMult(myArray1, myArray2, myArray);
PrintArray(myArray);
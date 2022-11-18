// Создадим массив через random
Random rnd = new Random();
int rows = rnd.Next(2,10);
int columns = rnd.Next(2,10);
int[,] numbers = new int[rows,columns];
int[] sumTotalColumn = new int[columns];
double[] averColumn = new double[columns];

FillArrayNull(sumTotalColumn); // заполним итоги нулями
FillRandomArray(numbers); // заполним массив

Print2DArray(numbers);

AverageColumns(numbers, sumTotalColumn, averColumn);
Console.WriteLine("==== Итоги ====");
PrintArray(sumTotalColumn);
Console.WriteLine("=== среднее ===");
PrintDoubleArray(averColumn);




// Функции
void AverageColumns(int[,] array, int[] sumCol, double[] averCol)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sumCol[j]+= array[i,j];
        }
        //averCol[i] = sumCol[i]/array.GetLength(1);
    }
}

void FillArrayNull(int[] array)
{
    for(int i=0; i < array.Length; i++)
        array[i] = 0;
}

void FillRandomArray(int[,] array)
{
    Random rnd = new Random();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(0,10);
        }
    }
}

void Print2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {            
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void PrintDoubleArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
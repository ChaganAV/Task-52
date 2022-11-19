// Создадим массив через random
Random rnd = new Random();
int rows = rnd.Next(2,10); int columns = rnd.Next(2,10); // строки и колонки массива 
int[,] numbers = new int[rows,columns]; // массив
int[] sumTotalColumn = new int[columns]; // итоги
int[] averColumn = new int[columns]; // среднее по колонкам
int min = 1; int max = 10; // для random

FillArrayNull(sumTotalColumn); // заполним итоги нулями
FillRandomArray(numbers); // заполним массив

Print2DArray(numbers);

AverageColumns(numbers, sumTotalColumn, averColumn);
Console.WriteLine("==== Итоги ====");
PrintArray(sumTotalColumn);
Console.WriteLine("=== среднее ===");
PrintArray(averColumn);




// Функции
void AverageColumns(int[,] array, int[] sumCol, int[] averCol)
{
    for(int col = 0; col < array.GetLength(1); col++)
    {
        for(int row = 0; row < array.GetLength(0); row++)
        {
            sumCol[col]+= array[row,col];
        }
        averCol[col] = sumCol[col]/array.GetLength(0); // среднее = сумма/количество
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
    for(int row = 0; row < array.GetLength(0); row++)
    {
        for(int col = 0; col < array.GetLength(1); col++)
        {
            array[row,col] = rnd.Next(min,max);
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
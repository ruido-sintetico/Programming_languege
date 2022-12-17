// SEMINAR 6

// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aₙₙ = m+n.
// Выведите полученный массив на экран.

Console.WriteLine("SEMINAR 7 Task 1.");
int[,] arr = CreateSomeArray(4,4);
Print2DArray(arr);

int [,] CreateSomeArray(int rows, int cols) {

    int [,] array2D = new int[rows, cols];
    for(int i = 0; i < rows; i++) {

        for(int j = 0; j < cols; j++) {

            array2D[i,j] = i + j;

        }
    }
    return array2D;
}

// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса нечётные, и замените эти элементы на их
// квадраты.
// Например, изначально массив выглядел вот так:
// 1 47 2
// 5 92 3
// 8 42 4
// Новый массив будет выглядеть вот так:
// 1 47 2
// 5 81 9
// 8 42 4
// 25 мин

Console.WriteLine("SEMINAR 7 Task 2.");
arr = CreateRandom2DArray(3,5);
Print2DArray(arr);
arr = ArrayWithChangedValue(arr);
Print2DArray(arr);

int [,] ArrayWithChangedValue(int[,] arr) {

    for(int i = 0; i < arr.GetLength(0); i++) {

        for(int j = 0; j < arr.GetLength(1); j++) {

            if(i % 2 != 0 && j % 2 != 0) {
                arr[i,j] = arr[i,j] * arr[i,j];
            }
        }
    }
    return arr;
}

// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив: 1 47 2
// 5 92 3
// 8 42 4
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.WriteLine("SEMINAR 7 Task 3.");
Console.WriteLine($"Summary of the main diagonal is {sumDiagonal(arr)}");

int sumDiagonal(int[,] arr) {
    
    int sum = 0;

    for(int i = 0; i < arr.GetLength(0); i++) {

        for(int j = 0; j < arr.GetLength(1); j++) {

            if(i == j) {
                sum += arr[i,j];
            }
        }
    }
    return sum;
}

// SEMINAR7 HOMEWORK

// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("SEMINAR 7 HOMEWORK Task 1.");
bool isParsedRows = int.TryParse(Console.ReadLine(), out int rows);
bool isParsedCols = int.TryParse(Console.ReadLine(), out int cols);
if(!isParsedCols || !isParsedRows) return;
double[,] arrT1H = CreateArrayWithDoubleElements(rows,cols);
Print2DDoubleArray(arrT1H);

double[,] CreateArrayWithDoubleElements(int rows, int cols) {

    double [,] array2D = new double[rows, cols];
    Random random = new Random();
    for(int i = 0; i < rows; i++) {

        for(int j = 0; j < cols; j++) {

            array2D[i,j] = Convert.ToDouble(random.Next(-100, 100)/10.0);

        }
    }
    return array2D;
}

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("SEMINAR 7 HOMEWORK Task 2.");
bool isParsedI = int.TryParse(Console.ReadLine(), out int i);
bool isParsedJ = int.TryParse(Console.ReadLine(), out int j);
if(!isParsedI || !isParsedJ) return;

Print2DArray(arr);
int value = TakeValueByIndexes(arr, i, j);
Console.WriteLine(value);

int TakeValueByIndexes(int[,] arr, int i, int j) {
    int val = 0;
    if(i < arr.GetLength(0) && j < arr.GetLength(1)) {
        val = arr[i,j];
        return val;
    }
    else Console.WriteLine($"Value with indexes {i+1}, {j+1} is not exist.");
    return val;
}

// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("SEMINAR 7 HOMEWORK Task 3.");
int[,] array = CreateRandom2DArray(3,4);
Print2DArray(arr);
double[] resultArr = GetAverageForEveryColumns(arr);
for(int n = 0; n < resultArr.Length; n++) {
    Console.Write($"Average value of the column number {n+1} is {resultArr[n]}\n");
}

double[] GetAverageForEveryColumns(int[,] array) {

    double[] resultArr = new double[arr.GetLength(1)];

    for(int j = 0; j < arr.GetLength(1); j++ ) {

        for(int i = 0; i < arr.GetLength(0); i++) {

            resultArr[j] = resultArr[j] + arr[i,j];
            
        }

        resultArr[j] = Math.Round(resultArr[j] / arr.GetLength(0), 2);

    }
    return resultArr;
 }

// COMMON METHODS

int[,] CreateRandom2DArray(int rows, int cols) {

    int [,] array2D = new int[rows, cols];
    Random rand = new Random();
    for(int i = 0; i < rows; i++) {

        for(int j = 0; j < cols; j++) {

            array2D[i,j] = rand.Next(-10, 11);

        }
    }

    return array2D;

}

void Print2DArray(int[,] arr) {

    for (int i = 0; i < arr.GetLength(0); i++) {
        Console.WriteLine("\n");
        for (int j = 0; j < arr.GetLength(1); j++) {
            Console.Write($"{arr[i,j]} \t");
        }
    }
    Console.WriteLine();
}

void Print2DDoubleArray(double[,] arr) {

    for (int i = 0; i < arr.GetLength(0); i++) {
        Console.WriteLine("\n");
        for (int j = 0; j < arr.GetLength(1); j++) {
            Console.Write($"{arr[i,j]} \t");
        }
    }
    Console.WriteLine();
}
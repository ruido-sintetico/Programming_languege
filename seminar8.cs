// SEMINAR 8

Console.WriteLine("How much rows?");
bool isParsedR = int.TryParse(Console.ReadLine(), out int r);
Console.WriteLine("How much columns?");
bool isParsedC = int.TryParse(Console.ReadLine(), out int c);
Console.WriteLine("Whar is minimal value?");
bool isParsedMin = int.TryParse(Console.ReadLine(), out int min);
Console.WriteLine("What is maximal value?");
bool isParsedMax = int.TryParse(Console.ReadLine(), out int max);

if(!isParsedC || !isParsedMax || !isParsedMin || !isParsedR) {

    Console.WriteLine("Incorrect value.");
    return;

}

int[,] arr = CreateRandom2DArray(r, c);

// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

Console.WriteLine("Seminar 8 task 1");
Print2DArray(arr);
Print2DArray(ChangeFirstAndLastRows(arr));

int[,] ChangeFirstAndLastRows(int[,] arr) {

    int[] tempArray = new int [arr.GetLength(1)];

    // Copy first row original array to tamp array
    for(int j = 0; j < arr.GetLength(1); j++) {

        tempArray[j] = arr[0, j];

    }
    // Copy first row original array to last row
    for(int j = 0; j < arr.GetLength(1); j++) {

        arr[0, j] = arr[(arr.GetLength(0) - 1), j];
        
    }
    // Copy temp array to last row
    for(int j = 0; j < arr.GetLength(1); j++) {

        arr[arr.GetLength(0) - 1, j] = tempArray[j];

    }
    
    return arr;

}

// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.WriteLine("Seminar 8 task 2");
Print2DArray(arr);
Print2DArray(ChangeRowsByColsInArray(arr));

int[,] ChangeRowsByColsInArray(int [,] arr) {

    if(arr.GetLength(0) != arr.GetLength(1)) {

        Console.WriteLine("Task might not be done. Rows more or less then cols.");
        return new int[0,0];

    }

    int[,] newArray = new int[arr.GetLength(0), arr.GetLength(1)];
    
    for(int i = 0; i < arr.GetLength(0); i++) {

        for(int j = 0; j < arr.GetLength(1); j++) {
            
            newArray[i,j] = arr[j,i];

        }

    }

    return newArray;

}

// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// Набор данных
// Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза 1 встречается 1 раз 2 встречается 1 раз 8 встречается 1 раз 9 встречается 3 раза
// 1, 2, 3 4, 6, 1 2, 1, 6
// 1 встречается 3 раза 2 встречается 2 раз 3 встречается 1 раз 4 встречается 1 раз 6 встречается 2 раза

Console.WriteLine("Seminar 8 task 3");
Print2DArray(arr);
PrintFreqDict(FillFreqDictionary(arr));

int[] FillFreqDictionary(int[,] arr) {

    int[] freqDict = new int[10];

    for(int i = 0; i < arr.GetLength(0); i++) {

        for(int j = 0; j < arr.GetLength(1); j++) {

            if(arr[i,j] < 0) {

                Console.WriteLine("Task has no solution!");
                return new int[0];

            }

            ++freqDict[arr[i,j]];

        }

    }

    return freqDict;

}

void PrintFreqDict(int[] arr) {

    for(int i = 0; i < arr.Length; i++) {
        if(arr[i] != 0) {
        
           Console.WriteLine($"Number {i} meet {arr[i]} times.");
        
        }

    }

}


//////////////////////////// SEMINAR 8 HOMEWORK

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Seminar 8 Homework task 1.");

Print2DArray(arr);
Print2DArray(SortRows(arr));

int [,] SortRows(int[,] arr) {

    int[] reversedArray = new int[arr.GetLength(1)];

    for(int i = 0; i < arr.GetLength(0); i++) { // i is row number

        for(int j = 0; j < arr.GetLength(1); j++) { // j is column number

            reversedArray[j] = arr[i,j];

        }

        Array.Sort(reversedArray);
        Array.Reverse(reversedArray);

        for(int j = 0; j < arr.GetLength(1); j++) { // j is column number

            arr[i,j] = reversedArray[j];

        }

    }
    
    return arr;

}

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Seminar 8 Homework task 2.");
Print2DArray(arr);
Console.WriteLine($"Row is minimal summary of elements is {GetRowNumberWithMinElemenentsSum(arr)}.");

int GetRowNumberWithMinElemenentsSum(int[,] arr) {

    int minSum = int.MaxValue;
    int row = 0;

    for(int i = 0; i < arr.GetLength(0); i++) {

        int sum = 0;

        for(int j = 0; j < arr.GetLength(1); j++) {

           sum += arr[i,j];

        }

        if(sum < minSum) {
        
            minSum = sum;
            row = i;

        }

    }

    return row;

}


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Seminar 8 Homework task 3.");
Console.WriteLine("How much rows?");
bool isParsedR2 = int.TryParse(Console.ReadLine(), out int r2);
Console.WriteLine("How much columns?");
bool isParsedC2 = int.TryParse(Console.ReadLine(), out int c2);

if(!isParsedC2 || !isParsedR2) {

    Console.WriteLine("Incorrect value.");
    return;

}

int[,] arr2 = CreateRandom2DArray(r2, c2);
Print2DArray(arr);
Print2DArray(arr2);
Print2DArray(GetMatrixMultiply(arr, arr2));


int[,] GetMatrixMultiply(int [,] arr1, int[,] arr2) {

    int numberOfRowsAndCols = arr1.GetLength(0);
    int[,] resultArray = new int[arr1.GetLength(0), arr2.GetLength(1)];

    if(arr1.GetLength(0) != arr2.GetLength(1)) {

        Console.WriteLine("Matrixes cant be multiplied.");
        return new int[0,0];

    }

    for(int i = 0; i < numberOfRowsAndCols; i++) {

        for(int j = 0; j < numberOfRowsAndCols; j++) {

            resultArray[i,j] = CountSumRowAndCol(arr1, arr2, i, j);

        }

    }

    return resultArray;

};

int CountSumRowAndCol(int[,] arr1, int[,] arr2, int r, int c) {
    
    int sum = 0;

    for(int i = 0; i < arr.GetLength(0); i++) {

        sum += arr1[r, i] * arr2[i, c];

    }

    return sum;

}


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Seminar 8 Homework task 4.");
int[,,] arr3d = CreateRandom3DArray(2,2,2);
Print3DArray(arr3d);

void Print3DArray(int[,,] arr) {

    for(int i = 0; i < arr.GetLength(0); i++) {

        for(int j = 0; j < arr.GetLength(1); j++) {

            for(int k = 0; k < arr.GetLength(2); k++) {

                Console.WriteLine($"{arr[i,j,k]}({i},{j},{k})");

            }

        }

    }

}



// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Seminar 8 Homework task 5.");
int[,] array = CreateRandom2DArray(4,4);
array = FillArrayByHourArrow(array);
Print2DArray(array);

int[,] FillArrayByHourArrow(int[,] arr) {

    int count = 1;
    for(int i = 0; i < arr.GetLength(0); i++) {
        arr[0,i] = count++;
    }
    for(int i = 1; i < arr.GetLength(1); i++) {
        arr[i,arr.GetLength(1) - 1] = count++;
    }
    for(int i = arr.GetLength(1) - 2; i >= 0; i--) {
        arr[arr.GetLength(0) - 1,i] = count++;
    }
    for(int i = arr.GetLength(0) - 2; i >= 1; i--) {
        arr[i,0] = count++;
    }
    for(int i = 1; i < 3; i++) {
        arr[1, i] = count++;
    }
    for(int i = 2; i > 0; i--) {
        arr[2,i] = count++;
    }
    return arr;
}




// COMMON METHODS


int[,] CreateRandom2DArray(int rows, int cols) {

    int [,] array2D = new int[rows, cols];
    Random rand = new Random();
    for(int i = 0; i < rows; i++) {

        for(int j = 0; j < cols; j++) {

            array2D[i,j] = rand.Next(min, max);

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

int[,,] CreateRandom3DArray(int rows, int cols, int lines) {

    int [,,] array3D = new int[rows, cols, lines];
    Random rand = new Random();
    for(int i = 0; i < rows; i++) {

        for(int j = 0; j < cols; j++) {

            for(int k = 0; k < lines; k++) {

                array3D[i, j, k] = rand.Next(min, max);

            }

        }
    }

    return array3D;

}

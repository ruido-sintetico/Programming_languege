// SEMINAR 5


Random random = new Random();

int[] arr = new int[10];
arr = CreateArrayFilledRandomValue(5);


// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.WriteLine("\nTask 1 Seminar5.");
PrintArray(arr);
PrintArray(ChangeSignElementsOfArray(arr));

int[] ChangeSignElementsOfArray (int[] arr) {

    int[] resultArray = new int[arr.Length];

    for (int i = 0; i < arr.Length; i++) {

        resultArray[i] = arr[i] * -1;

    }

    return resultArray;

}

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет -3; массив [6, 7, 19, 345, 3] -> да

Console.WriteLine("\nTask 2 Seminar5.");
PrintArray(arr);

bool isParsed = int.TryParse(Console.ReadLine(), out int n);
if (!isParsed) {

    Console.WriteLine("Task 2 Seminar 5. Incorrect n");
    return;

}

if(isNumberInArray(arr, n) == true) Console.WriteLine($"Array have {n}.");
else Console.WriteLine($"Array have NOT {n}.");

bool isNumberInArray(int[] array, int n) {

    for (int i = 0; i < array.Length; i++) {

        if (array[i] == n) return true;

    }

    return false;

}

// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1 [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.WriteLine("\nTask 3 Seminar5.");
int[] task3Arr = CreateArrayFilledRandomValue(20);
PrintArray(task3Arr);

Console.WriteLine($"Amount numbers between 10 and 99 is {CountValuesBetween10and99InArray(task3Arr)}.");

int CountValuesBetween10and99InArray (int[]arr) {

    int count = 0;

    for( int i = 0; i < arr.Length; i++ ) {
        
        if( arr[i] > 10 && arr[i] < 99 ) ++count;

    }

    return count;

}

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3; [6 7 3 6] -> 36 21

Console.WriteLine("\nTask 4 Seminar5.");
PrintArray(arr);
PrintArray(MultiplyPairElementsInArray(arr));


int[] MultiplyPairElementsInArray(int[] arr) {

    int[] resultArray = new int[arr.Length / 2 + arr.Length % 2];

    for(int i = 0; i < resultArray.Length; ++i) {

        
        if(i != arr.Length - i - 1) {
            resultArray[i] = arr[i] * arr[arr.Length - i - 1];
        }
        else {
            resultArray[i] = arr[i];
        }

    }

    return resultArray;


}




// HOMEWORK

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("\nTask 1 HomeWork Seminar5.");
PrintArray(arr);

int count = CountEvenValueInArray(arr);
Console.WriteLine(count);

int CountEvenValueInArray(int[] array){

    int count = 0;

    for (int i = 0; i < array.Length; i++) {

        if (array[i] % 2 == 0){
            ++count;
        };

    };

    return count;

};



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("\nTask 2 HomeWork Seminar5.");
PrintArray(arr);
Console.WriteLine($"Summary odd elements is {CountOddElementsInArray(arr)}.");

int CountOddElementsInArray (int [] array) {

    int oddElementsSum = 0;

    for (int i = 1; i < array.Length; i = i + 2) {

        oddElementsSum = oddElementsSum + array[i];

    }

    return oddElementsSum;

}


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("\nTask 3 HomeWork Seminar5.");
PrintArray(arr);
int min = TakeMinElementInArray(arr);
int max = TakeMaxElementInArray(arr);
Console.WriteLine($"Max = {max}, Min = {min}");
Console.WriteLine($"Result of subtraction max and min value in array is {max - min}.\n");

int TakeMinElementInArray(int [] array) {

    int min = array[0];

    for(int i = 0; i < array.Length; i++) {

        if (array[i] < min) {
            min = array[i];
        }

    }

    return min;

}

int TakeMaxElementInArray(int [] array) {

    int max = array[0];

    for(int i = 0; i < array.Length; i++) {

        if (array[i] > max) {
            max = array[i];
        }

    }

    return max;

}


// Common Methods

int[] CreateArrayFilledRandomValue(int l)
{

    int[] array = new int[l];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-100, 100);
    };

    return array;

};

void PrintArray(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }

    Console.Write("]");
    Console.WriteLine();
};


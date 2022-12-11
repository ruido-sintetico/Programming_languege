// SEMINAR 6

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("\nTask 1 Seminar 6.");
Console.WriteLine("Enter sides length of triangle.");
bool isParsed1 = int.TryParse(Console.ReadLine(), out int a);
bool isParsed2 = int.TryParse(Console.ReadLine(), out int b);
bool isParsed3 = int.TryParse(Console.ReadLine(), out int c);

if (!isParsed1 && !isParsed2 && !isParsed3) {
    Console.WriteLine("Incorrect value.");
    return;
}

if (IsTriangleByThreeSides(a, b, c)) Console.WriteLine("It is triangle.");
else Console.WriteLine("It is NOT triangle.");

bool IsTriangleByThreeSides(int a, int b, int c) {
    
    if(a < b + c && b < a + c && c < b + a) {

        return true;

    }

    return false;

}

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное. 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("\nTask 2 Seminar 6.");
Console.WriteLine("Enter a number.");
bool isParsed = int.TryParse(Console.ReadLine(), out int number);

Console.WriteLine($"Number {number} in binary is {GetStringDivision2(number)}.");

string GetStringDivision2(int number) {

    int reminder = number % 2;
    number = number / 2;

    while (number >= 1) {
        if (reminder == 0) return (GetStringDivision2(number) + "0");
        return (GetStringDivision2(number) + "1");
    }
    return "1";

}

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3 Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("\nTask 3 Seminar 6.");
Console.WriteLine("Enter a number.");
bool isParsedT3 = int.TryParse(Console.ReadLine(), out int t3number);

PrintArray(NumberOfFibonacci(t3number));

int[] NumberOfFibonacci(int n) {

    int[] arr = new int[n];
    arr[0] = 0; arr[1] = 1;
    for(int i = 2; i < n; i++) {
        arr[i] = arr[i-1] + arr[i-2];
    }

    return arr;

} 

// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

Console.WriteLine("\nTask 49 Seminar 6.");
Random random = new Random();
int length = random.Next(10, 20);
int[] arr = CreateArrayFilledRandomValue(length);
PrintArray(arr);
PrintArray(CopyArrayByElements(arr));

int[] CopyArrayByElements(int[] arr) {

    int[] newArray = new int[arr.Length];

    for(int i = 0; i < arr.Length; i++) {
        newArray[i] = arr[i];
    }

    return newArray;

}

// SEMINAR 6 HOMEWORK

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("\nTask 1 HOMEWORK Seminar 6.");
Console.WriteLine("\nEnter elements number.");
bool isParsedT1H = int.TryParse(Console.ReadLine(), out int n);
if(!isParsedT1H) {
    Console.WriteLine("Incorrect value.");
    return;
}
int[] t1HArray = FillArrayByUser(n);
Console.WriteLine($"Amount of number more then zero is {CountMoreZero(t1HArray)}");

int CountMoreZero(int[] arr) {

    int count = 0;

    for(int i = 0; i < arr.Length; i++) {
        if(arr[i] > 0) ++count;
    }

    return count;

}

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("\nTask 2 HOMEWORK Seminar 6.");
Console.WriteLine("Enter the coefficients.");
bool isParsed1T2H = double.TryParse(Console.ReadLine(), out double k1);
bool isParsed2T2H = double.TryParse(Console.ReadLine(), out double k2);
bool isParsed3T2H = double.TryParse(Console.ReadLine(), out double b1);
bool isParsed4T2H = double.TryParse(Console.ReadLine(), out double b2);

if (!isParsed1T2H && !isParsed2T2H && !isParsed3T2H && !isParsed4T2H) {
    Console.WriteLine("Incorrect value.");
    return;
}

double[] coords = FindCoordinates(k1, k2, b1, b2);

Console.WriteLine($"({coords[0]}, {coords[1]})");

double [] FindCoordinates (double k1, double k2, double b1, double b2) {

    double [] coords = new double [2];

    double x = -(b1 - b2) / (k1 - k2);Console.WriteLine($"{-(b1 - b2)}, {k1 - k2}, {x}");
    double y = k1 * x + b1; Console.WriteLine(y);

    coords[0] = x; coords[1] = y;

    return coords;

}

// Common Methods

void PrintArray(int[] array) {
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }

    Console.Write("]");
    Console.WriteLine();
};

int[] CreateArrayFilledRandomValue(int l) {

    int[] array = new int[l];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-100, 100);
    };

    return array;

}

int[] FillArrayByUser(int n) {

    int[] arr = new int[n];

    for(int i = 0; i < n; i++) {
    
        isParsedT1H = int.TryParse(Console.ReadLine(), out number);
        if(!isParsedT1H) {
            Console.WriteLine("Incorrect value. Insert zero.");
            arr[i] = 0;
        }
        else arr[i] = number;

    }

    return arr;

}
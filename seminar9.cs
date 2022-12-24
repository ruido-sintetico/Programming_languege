// SEMINAR 9

Console.WriteLine("Enter a number n.");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
if (!isParsedN) {

    Console.WriteLine("Incorrect value.");
    return;

}

string originString = "";

// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.WriteLine("\nSeminar 9 Task 1.");

string resultString = NumberFrom1ToN(n, originString);
Console.WriteLine(resultString);

string NumberFrom1ToN(int n, string str) {

    if (n > 1) {

        str = str + NumberFrom1ToN(n - 1, str);

    }

    return str + n + ", ";
};

// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5" M = 4; N = 8 -> "4, 6, 7, 8"

Console.WriteLine("\nSeminar 9 Task 2.");
Console.WriteLine("Enter a number m.");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
if (!isParsedM) {

    Console.WriteLine("Incorrect value.");
    return;

}

if (n < m) {
    
    Console.WriteLine("Incorrect value. Require n>m");
    return;

}

resultString = NumberFromNToM(n, m, originString);
Console.WriteLine(resultString);

string NumberFromNToM(int n, int m, string str) {

    if (n > m) {

        str = str + NumberFromNToM(n - 1, m, str);

    }

    return str + n + ", ";
};

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12 45 -> 9

Console.WriteLine("\nSeminar 9 Task 3.");
Console.WriteLine(SumOfDigits(n));

int SumOfDigits (int n) {

    if (n / 10 == 0) {

        return n;

    }
    else {

    return SumOfDigits(n / 10) + n % 10;

    }

}

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (35) A = 2; B = 3 -> 8

Console.WriteLine("\nSeminar 9 Task 4.");
Console.WriteLine($"{PowNToM(n, m)}");

if (m < 0) return;
int PowNToM(int n1, int n2, int res = 1, int count=1) {

    if (count <= n2) {
        res = res * n1;
        res = PowNToM(n1, n2, res, count + 1);
    }
    
    
    return res;

}

// Seminar 9 Homework

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Seminar 9 Homework 1.");

string resultReversedString = NumberFromNTo1(n, originString);
Console.WriteLine(resultReversedString);

string NumberFromNTo1(int n, string str) {

    if (n > 1) {

        str = str + NumberFromNTo1(n - 1, str);

    }

    return "" + n + ", " + str;
};

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Seminar 9 Homework 2.");
int sumElements = SumElementsFromNToM(n);
Console.WriteLine($"{sumElements}");

int SumElementsFromNToM(int n, int sum = 0) {

    if (n > 1) {
        
        sum = sum + SumElementsFromNToM(n - 1, sum);

    }

    return n + sum;
};



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Seminar 9 Homework 3.");
int acker = Ackerman(n, m);
Console.WriteLine(acker);
int Ackerman (int n, int m) {
    
    int z = 0;                        
    if(n == 0) z = (m + 1);
    else if (m == 0 && n != 0){

            z = Ackerman(n - 1,1);
        
    }
    else if (m > 0 && n > 0) {
        
        z = Ackerman(n - 1, (Ackerman(n, m - 1)));
        
    }  
         
    return z;
}



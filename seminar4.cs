// SEMINAR 4

// Task 1
// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// Test

int [] basicArray = new int[] { -1, 1, 0, 4567, -3746 };
int [] resultArray = new int[] { 1, 1, 0, 4, 4 };

for ( int i = 0; i < basicArray.Length; ++i) {
    
    if ( CountDigit( basicArray[i] ) == resultArray[i] ) {
        Console.WriteLine($"Method work correctly.");
    }
    else {
        Console.WriteLine($"Method does not work correctly.");
    }

};

// End of the test

Console.WriteLine("Enter X");

bool isParsed = int.TryParse(Console.ReadLine(), out int n);

if (!isParsed) {
    
    Console.WriteLine("Incorrect value");
    return;

}
if (n == 0) {

    Console.WriteLine($"Entered number = 0, no digit");
    return;

}

Console.WriteLine($"Number of digit in {n} = {CountDigit(n)} digit.");

// Method

int CountDigit (int n) {

    int amount = 0;

    while ( n != 0) {
        n = n / 10;
        amount = ++amount;
    };

    return amount;
}

// End of the method

// Task 2
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

Console.WriteLine("Enter X");

bool isParsed = int.TryParse(Console.ReadLine(), out int n);

if (!isParsed) {
    
    Console.WriteLine("Incorrect value");
    return;

};

Console.WriteLine ($"{MultyplyFromOneToNumber (n)}");

double MultyplyFromOneToNumber (int number) {

    double amount = 1;

    if ( n > 0 ) {
     
        for ( int i = 1; i <= n; ++i) {
        
            amount = amount * i;

        }

        return amount;

    };

    if ( n < 0 ) {
        
        for ( int i = -1; i >= n; --i) {
        
            amount = amount * i;

        }

        return amount;

    };

    return 0;

}

// Task 3
// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

Random random = new Random ();
int n = 8;
int [] array = new int [n];

// Test

int [] arrayTest = new int [8];
arrayTest = FillArrayByRandomValue( 8, arrayTest );

for (int i = 0; i < 8; ++i) {
    if ( arrayTest [i] > 1 || arrayTest[i] < -1 ) {

        Console.WriteLine("Method does NOT work!");

    }
    else Console.WriteLine("Method work correctly!");
};

// TestEnd

FillArrayByRandomValue( n, array);
PrintArray(array);

int [] FillArrayByRandomValue (int n, int [] array){

    for ( int i = 0; i < n; ++i) {

        array [i] = random.Next(2);
        Console.WriteLine(array [i]);

    };
    return array;

};

void PrintArray (int [] arr) {
    Console.Write("[");
    for (int i = 0; i < arr.Length; ++i) {
        
        Console.Write(arr[i]);
    
    }
    Console.Write("]");
    Console.WriteLine("");
}

// SEMINAR 3 HOMEWORK

// Task 1
// Напишите программу, которая принимает на вход два числа (A и B) и метод который возводит число A в натуральную степень B.
// Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. Не использовать Math.Pow()

bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
bool isParsedD = int.TryParse(Console.ReadLine(), out int d);

if (!isParsedN || !isParsedD) {
    
    Console.WriteLine("Incorrect value");
    return;

}

Console.WriteLine(Exponentiate ( n, d ));

int Exponentiate (int n, int d) {
    
    int result = 1;
    for( int i = 0; i < d; ++i) {
        result = result * n;
    }
    return result;
}

// Task 2
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Random random = new Random ();
int number = random.Next(999999999);

// Test

Console.WriteLine("Testing...");

int [] basicArray = new int [4] { 3, 34, 89878, 484933333 };
int [] resultArray = new int [4] { 3, 7, 40, 40 };

for ( int i = 0; i < basicArray.Length; ++i) {

    if ( SumOfDigits(basicArray[i]) == resultArray[i] ) {
        Console.WriteLine($"Method work correctly.");
    }
    else {
        Console.WriteLine($"Method does not work correctly.");
    }

};

// TestEnd

Console.WriteLine(number);
Console.WriteLine (SumOfDigits(number));

int SumOfDigits (int n) {

    int result = 0;
    for ( int i = n ; i != 0; ) {

        result = result + i % 10;
        i = i / 10;

    }
    return result;
}

// Task 3
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран



Random random = new Random ();
int n = 8;
int [] array = new int [n];

FillArrayByRandomValue( n, array);
PrintArray(array);

int [] FillArrayByRandomValue (int n, int [] array){

    for ( int i = 0; i < n; ++i) {

        array [i] = random.Next(100);
        Console.WriteLine(array [i]);

    };
    return array;

};

void PrintArray (int [] arr) {
    Console.Write("[");
    for (int i = 0; i < arr.Length; ++i) {
        
        Console.Write(arr[i]);
    
    }
    Console.Write("]");
    Console.WriteLine("");
}


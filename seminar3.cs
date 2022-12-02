// SEMINAR 3

// Task 1
// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)

/*

Console.WriteLine("Enter X");
bool isParsedX = int.TryParse(Console.ReadLine(), out int x);

Console.WriteLine("Enter Y");
bool isParsedY = int.TryParse(Console.ReadLine(), out int y);

if (!isParsedX || !isParsedY) Console.WriteLine("Incorrect value");
else GetQuaterNumberByCoordinates ( x, y );

void GetQuaterNumberByCoordinates (int x, int y) {
    
    if ( x > 0 && y > 0 ) Console.WriteLine("Quarter number is 1");
    if ( x > 0 && y < 0 ) Console.WriteLine("Quarter number is 2");
    if ( x < 0 && y > 0 ) Console.WriteLine("Quarter number is 4");
    if ( x < 0 && y > 0 ) Console.WriteLine("Quarter number is 3");
    
    return;

};
*/

// Task 2
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

/*

Console.WriteLine("Enter X1, Y1");

bool isParsedX1 = int.TryParse(Console.ReadLine(), out int x1);
bool isParsedY1 = int.TryParse(Console.ReadLine(), out int y1);

Console.WriteLine("Enter X2, Y2");

bool isParsedX2 = int.TryParse(Console.ReadLine(), out int x2);
bool isParsedY2 = int.TryParse(Console.ReadLine(), out int y2);

if (!isParsedX1 || !isParsedY1 || !isParsedX2 || !isParsedY2) Console.WriteLine("Incorrect value");
else Console.WriteLine ($"Distance is {GetDistanceBetweenTwoPoints (x1, x2, y1, y2)}.");

double GetDistanceBetweenTwoPoints ( int x1, int x2, int y1, int y2 ) {

    double distance = Math.Sqrt ( Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    return distance;

}

*/

// Task 3
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

/*

Console.WriteLine("Enter X");
bool isParsed = int.TryParse(Console.ReadLine(), out int n);

if (!isParsed) Console.WriteLine("Incorrect value");
else PrintSquareTable(n);

void PrintSquareTable (int n) {

    for (int i = 0; i <= n; ++i) {

        Console.WriteLine ($"{i} * {i} = {i * i}");

    }

    return;
}

*/

// SEMINAR 3 HOMEWORK

// Task 1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. Не использовать String!

Console.WriteLine("Enter N");
bool isParsed = int.TryParse(Console.ReadLine(), out int n);

if ( !isParsed || n < 10000 || n > 99999) Console.WriteLine ("Value uncorrect.");
else {

    if (isPolindrom(n) == true) Console.WriteLine ("Number is polindrom");
    else Console.WriteLine ("Number is NOT polindrom");

}

bool isPolindrom (int n) {

    if (( n / 10000 ) == ( n % 10 )) {

        int n1 = n / 10 % 1000;
        if ( ( n1 / 100) == ( n1 % 10 ) ) return true;
        return false;
    }
    return false;

}

// Task 2
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.

/*

Console.WriteLine("Enter X1, Y1, Z1");

bool isParsedX1 = int.TryParse(Console.ReadLine(), out int x1);
bool isParsedY1 = int.TryParse(Console.ReadLine(), out int y1);
bool isParsedZ1 = int.TryParse(Console.ReadLine(), out int z1);

Console.WriteLine("Enter X2, Y2, Z2");

bool isParsedX2 = int.TryParse(Console.ReadLine(), out int x2);
bool isParsedY2 = int.TryParse(Console.ReadLine(), out int y2);
bool isParsedZ2 = int.TryParse(Console.ReadLine(), out int z2);

if (!isParsedX1 || !isParsedY1 || !isParsedX2 || !isParsedY2 || !isParsedZ1 || !isParsedZ2) Console.WriteLine("Incorrect value");
else Console.WriteLine ($"Distance is {GetDistanceBetweenTwoPoints3D (x1, x2, y1, y2)}.");

double GetDistanceBetweenTwoPoints3D ( int x1, int x2, int y1, int y2 ) {

    double distance = Math.Sqrt ( Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    return distance;

}

*/

// Task 3
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// Задание должно быть выполнено в методе и метод должен вернуть массив чисел.

/*

Console.WriteLine("Enter X");
bool isParsed = int.TryParse(Console.ReadLine(), out int n);
double [] result = new double [n + 1];

if (!isParsed) Console.WriteLine("Incorrect value");
else {

    double [] array = GetCubeTable(n);
    PrintArray(array);

}

void PrintArray ( double [] array) {

    Console.WriteLine ( "Array has been printed soon." );

    for ( int i = 0; i < array.Length; i++ ) {

        Console.Write ( $"{array [i]}," );

    }

    Console.WriteLine ( "" );
};

double [] GetCubeTable (int n) {

    for ( int i = 0; i <= n; i++ ) {

        result [i] = Math.Pow(i, 3);

    }
    return result;
}

*/
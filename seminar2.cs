// SEMINAR 2

/*

// Task 1

int random = new Random().Next(100, 1000);

Console.WriteLine(random);

int firstNumber = random / 100;
int lastNumber = random % 10;

Console.WriteLine(firstNumber);
Console.WriteLine(lastNumber);

Console.WriteLine(firstNumber * 10 + lastNumber);

*/

/*

// Task 2

int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());

int ostatok = firstNumber % secondNumber;

if (ostatok == 0) Console.WriteLine("Первое число кратно второму");
else Console.WriteLine($"Первое число НЕ кратно второму {ostatok}");

*/

/*

// Task 3

int number = int.Parse(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0) Console.WriteLine("Да!");
else Console.WriteLine("Нет!");

*/

/*

// Task 4

int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());

int square1 = firstNumber * firstNumber;
int square2 = secondNumber * secondNumber;

if (square1 == secondNumber || square2 == firstNumber) Console.WriteLine("ДА!");
else Console.WriteLine("НЕТ!");

*/


// SEMINAR 2 HOMEWORK

// Task 1

/*

Console.WriteLine("Enter three-digit number");

int t1Number = int.Parse(Console.ReadLine());

if (t1Number / 100 > 1 && t1Number / 1000 < 1) {
    
    int t1Ostatok = t1Number % 100;
    int t1SecondNumber = t1Ostatok / 10;
    
    Console.WriteLine($"Number of second digit is {t1SecondNumber}");

}
else Console.WriteLine($"{t1Number} is NOT three-digit number!");

*/

// Task 2

/*

Console.WriteLine("Enter number");

int t2Number = int.Parse(Console.ReadLine());

if (t2Number < 100) Console.WriteLine($"t2Number is less then 100!");
else {
    while (t2Number > 999) {

        t2Number = t2Number / 10;

    }

    int lastNumber = t2Number % 10;

    Console.WriteLine($"Number of third digital is {lastNumber}");
}

*/

// Task 3

Console.WriteLine("Enter number from 1 to 7");

int t3Number = int.Parse(Console.ReadLine());

if (t3Number < 1 || t3Number >7) Console.WriteLine("Number is NOT correct!");
else {

    int Mo = 1;
    int Tu = 2;
    int We = 3;
    int Th = 4;
    int Fr = 5;
    int Sa = 6;
    int Su = 7;

    if (t3Number < 6) Console.WriteLine("It is NOT weekend!");
    else Console.WriteLine("It is weekend!");

}

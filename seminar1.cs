// Seminar 1 

// Task1



Console.WriteLine("Enter 2 numbers");

int numberOne = int.Parse(Console.ReadLine());
int numberTwo = int.Parse(Console.ReadLine());

if (numberOne < numberTwo) Console.WriteLine("First number is less then second number");
else Console.WriteLine("First number is more then second number");



// Task 2



Console.WriteLine("Enter three number");

int numberOne = int.Parse(Console.ReadLine());
int numberTwo = int.Parse(Console.ReadLine());
int numberThree = int.Parse(Console.ReadLine());

if (numberOne > numberTwo) {

    if (numberOne < numberThree) Console.WriteLine("Number three is the biggest.");

    else Console.WriteLine("Number one is the biggest.");

} else if (numberTwo > numberThree) Console.WriteLine("Number two is the biggest.");

else Console.WriteLine("Number three is the biggest.");



// Task 3



Console.WriteLine("Enter three number");

int number = int.Parse(Console.ReadLine());

if (number % 2 == 0) Console.WriteLine("Number is even.");

else Console.WriteLine("Number is NOT even.");



// Task 4


Console.WriteLine("Enter number");

int number = int.Parse(Console.ReadLine());
int i = 1;

while (i <= number) {
    if (i % 2 == 0)
    Console.Write(i);
    Console.Write(" ");
    i++;
}
Console.WriteLine();

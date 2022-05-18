/*
! While Loop
    - Continues to loop while a condition is true.
*/

int total = 1; 
while (total != 10) // If total is not equal to 10, it will execute the block of code within the curly brackets { }
{
    // will run if total is not 10.
    System.Console.WriteLine(total);
    total = total + 1; // For each iteration, we update the value of total.
}

total = 0; // Reset total
while(true) // Passing a "True" will allow us to run this loop.
{
    if(total == 10) // Once total is equal to 10, this will execute our WriteLine and break from our loop.
    {
        System.Console.WriteLine("Goal Reached");
        break;
    }

    total++; // add 1 to the current value of our variable "total".
}

bool isOn = true;
int time = 1;
while(isOn)
{
    System.Console.WriteLine("The light is on.");
    if(time == 7)
    {
        isOn = false;
        System.Console.WriteLine("The light is off.");
    }
    time++;
}

Random rando = new Random(); // C# offers a random number object based off time in miliseconds.
int someNum;
bool keepLooping = true;
while(keepLooping)
{
    someNum = rando.Next(1, 21); // Next() is how we call that new number from our Random object.
    // - Next(min value, max value + 1) - for 1 - 20, we would need to put 1, 21

    if(someNum == 15 || someNum == 8)
    {
        System.Console.WriteLine("Skipped!");
        continue;
    }

    System.Console.WriteLine("RANDOM: " + someNum);
    if(someNum == 10)
    {
        keepLooping = false;
    }
}

/*
! For Loops
    - checks a value, compares our condition, and possibly changes the value we check against
*/

int studentCount = 21;

for(int i = 0; i < studentCount; i++) // i is our starting value, if condition is true, executes code within { } 
{
    System.Console.WriteLine("For Loop: " + i);
}

for(int i = 0; i != 15; i = rando.Next(1,21))
{
    System.Console.WriteLine($"Random Number: {i}");
}

string firstName = "Eric";
string lastName = "Winebrenner";
System.Console.WriteLine(firstName + " " + lastName);
System.Console.WriteLine($"{firstName} {lastName}");

string[] students = {"Deron", "Andra", "Braeden", "Connor", "Liz" };
for(int i = 0; i < students.Length; i++)
{
    System.Console.WriteLine(students[i]);
}

//! Challenge!
/*
    - Write a for loop that counts from 0 to 100.
        - For each iteration, If the number (i) is divisible by:
            - 3: WriteLine "Fizz"
            - 5: WriteLine "Buzz"
            - Both 3 & 5: WriteLine "Fizz Buzz"
        - Otherwise, just print the value of the number.
*/

for(int i = 0; i <= 100; i++)
{
    if(i % 5 == 0 && i % 3 == 0)
    {
        System.Console.WriteLine("Fizz Buzz");
    }
    else if( i % 3 == 0)
    {
        System.Console.WriteLine("Fizz");
    }
    else if( i % 5 == 0)
    {
        System.Console.WriteLine("Buzz");
    }
    else
    {
        System.Console.WriteLine(i);
    }

}

/*
! ForEach Loops
    - A simplier way to possibly write for loops
    - We can cycle through an array
*/

foreach(string student in students)
{
    System.Console.WriteLine($"{student} is a student in the class.");
}

string fullName = firstName + " " + lastName;
foreach(char letter in fullName)
{
    if(letter != ' ')
    {
        System.Console.WriteLine(letter);
    }
}

/*
!   Do While Loops
        - Does at least 1 iteration of a loop and THEN checks the while condition.
*/

int iterator = 0;
do{
    System.Console.WriteLine("Hello");
    iterator++;
} while (iterator < 5);

if(iterator == 5)
{
    System.Console.WriteLine("It's five");
}
/*
!   Arithmetic Operators
    Math and logic operators
*/

int a = 10;
int b = 2;
System.Console.WriteLine(a + b);

int difference = a - b;
System.Console.WriteLine(difference);
System.Console.WriteLine(a * b);
System.Console.WriteLine(a / b);

int numberA = 22;
int numberB = 15;
System.Console.WriteLine(numberA / numberB); // Provides an incorrect value because the return is an "int".
System.Console.WriteLine((decimal) numberA / (decimal) numberB);
System.Console.WriteLine(numberA % numberB); // Modulus - the remainder of what has been divided

DateTime now = DateTime.Now;
DateTime someDay = new DateTime(1985, 10, 26);
TimeSpan timeSpan = now - someDay;
System.Console.WriteLine(timeSpan / 365); // displays the number of years

/*
!   Comparison Operators
    Compare two different values in a certain way.
*/

string name = "Peter";
string anotherName = "peter";
System.Console.WriteLine(name == "Peter"); // Returns True
System.Console.WriteLine(name == anotherName); // Returns False

int age = 30;
bool notEqual = age != 123;
System.Console.WriteLine(notEqual); // Provides us a True value because age is NOT equal to 123

List<string> firstList = new List<string>();
List<string> secondList = new List<string>();

firstList.Add(name);
secondList.Add(name);

System.Console.WriteLine(firstList == secondList);
// Returns false because they have different addresses in memory. If you were to compare somthing like this, you would need to compare the exact items within the list (done with a loop).

bool greaterThan = age > 12; // True
bool greaterThanOrEqual= age >= 18;
bool lessThan = age < 100; // True 
bool lessThanOrEqual = age <= 20; // False

//* OR
bool orValue = lessThan || lessThanOrEqual;
System.Console.WriteLine($"OR: {orValue}");

//* AND
int x = 3;
bool andValue = x < 5 && greaterThan;
System.Console.WriteLine($"AND: {andValue}");



if (x > 5 && x > 2 || x < 50)
{
    System.Console.WriteLine("Yup");
}
else
{
    System.Console.WriteLine("Nope");
}
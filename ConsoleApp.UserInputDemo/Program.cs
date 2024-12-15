// Declare variables
string? firstName = string.Empty;
string lastName = string.Empty;
int age = 0;
int retirementAge = 65;
decimal salary = 0;
char gender = char.MinValue;
bool working = true;

// Prompt the for input
Console.Write("Please anter your first name: ");
firstName = Console.ReadLine();

Console.Write("Please anter your last name: ");
lastName = Console.ReadLine();

// Process the data
Console.Write("Please anter your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please anter your salary: ");
salary = Convert.ToDecimal(Console.ReadLine());

Console.Write("Please anter your gender (M or F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you working? (true or false): ");
working = Convert.ToBoolean(Console.ReadLine());

// Process the data
int workingYearsRemaining = retirementAge - age;

// Output the results to the user
Console.WriteLine($"Full name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Your salary is: {salary}");
Console.WriteLine($"Your Gender is: {gender}");
Console.WriteLine($"You Are Employed: {working}");
Console.WriteLine($"Working yares remaining: {workingYearsRemaining}");
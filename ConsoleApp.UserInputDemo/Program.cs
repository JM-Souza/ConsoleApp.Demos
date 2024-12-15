// Declare variables
string firstName = string.Empty;
string lastName = string.Empty;
int age = 0;
int retirementAge = 65;

// Prompt the for input
Console.WriteLine("Please anter your first name");
firstName = Console.ReadLine();

Console.WriteLine("Please anter your last name");
lastName = Console.ReadLine();

// Process the data
Console.WriteLine("Please anter your age");
age = Convert.ToInt32(Console.ReadLine());
int workingYearsRemaining = retirementAge - age;

// Output the results to the user
Console.WriteLine($"Full name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Working yares remaining: {workingYearsRemaining}");
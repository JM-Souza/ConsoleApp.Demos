// Declare variables
string name = string.Empty;
int age = 0;
int retirementAge = 65;

// Prompt the for input
Console.WriteLine("Please anter your name");
name = Console.ReadLine();

// Process the data
Console.WriteLine("Please anter your age");
age = Convert.ToInt32(Console.ReadLine());
int workingYearsRemaining = retirementAge - age;

// Output the results to the user
Console.WriteLine($"Full name: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Working yares remaining: {workingYearsRemaining}");
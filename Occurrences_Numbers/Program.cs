// Initialize random number generator
Random random = new Random();

// Generate an array of 100 random integers between 20 and 40
int[] randomArray = new int[100];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = random.Next(20, 41);
}

// Display the generated array
Console.WriteLine("Generated Array:");
Console.WriteLine(string.Join(", ", randomArray));

// Count occurrences of each unique number in the array
Dictionary<int, int> occurrences = randomArray
    .GroupBy(num => num)
    .ToDictionary(group => group.Key, group => group.Count());

// Display the occurrences
Console.WriteLine("\nNumber Occurrences:");
foreach (var item in occurrences)
{
    Console.WriteLine($"Number {item.Key} occurs {item.Value} times");
}
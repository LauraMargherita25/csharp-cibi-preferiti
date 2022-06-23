// See https://aka.ms/new-console-template for more information


// New array
string[] favoriteFoods = { "pizza", "carbonara", "tiramisù", "takoyaki", "gyoza", "pasta al pesto", "fiorentina", "ramen" };

// Array length 
Console.Write("\nTotal Number of Elements: ");
Console.WriteLine(favoriteFoods.Length);

// Listing array
Console.WriteLine("List of favourite foods:");
foreach (string food in favoriteFoods)
    Console.WriteLine(food);

// First Middle Last positions
Console.WriteLine("first in the standings: " + favoriteFoods[0]);
Console.WriteLine("last in the standings: " + favoriteFoods.Last());
Console.WriteLine("half in the standigs: " + favoriteFoods[favoriteFoods.Length / 2 - 1] + " " + favoriteFoods[favoriteFoods.Length / 2]);

//Ask fvorite food
Console.WriteLine("Enter yours favorite food:");

string userFavoriteFood = Console.ReadLine();

Console.WriteLine("User favorite food is: " + userFavoriteFood);


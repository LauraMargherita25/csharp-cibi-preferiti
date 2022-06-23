// See https://aka.ms/new-console-template for more information

string[] favoriteFoods = { "pizza", "carbonara", "tiramisù", "takoyaki", "gyoza", "pasta al pesto", "fiorentina", "ramen" };

Console.WriteLine(favoriteFoods.Length);

foreach (string food in favoriteFoods)
    Console.WriteLine(food);

Console.WriteLine("primo in classifica: " + favoriteFoods[0]);
Console.WriteLine("ultimo in classifica: " + favoriteFoods.Last());
Console.WriteLine("a metà classifica: " + favoriteFoods[favoriteFoods.Length / 2 - 1] + " " + favoriteFoods[favoriteFoods.Length / 2]);


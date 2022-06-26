// See https://aka.ms/new-console-template for more information

internal class Program
{
    static void Main(string[] args)
    {

        // Dati che miservono
        string[] favoriteFoods = { "pizza", "carbonara", "tiramisù", "takoyaki", "gyoza", "pasta al pesto", "fiorentina", "ramen" };
        int computerFavoriteFood = 0;
        string userFavoriteFood;
        bool notFound = true;

        // cerco il cibo prefe del computer
        //for (int i = 0; i < favoriteFoods.Length; i++)
        //{
        //    if (i == computerFavoriteFood)
        //    {

        //        Console.WriteLine((i + 1) + "-" + favoriteFoods[i] + "==> questo è il cibo preferito del computer");
        //    } 
        //    else
        //    {

        //        Console.WriteLine((i + 1) + "-" + favoriteFoods[i]);
        //    };

        //}

        //FAI la lettura della stringa inserita dall'utente
        //CICLA sulla lunghezza dell'arrey per trovare SE  userFavoriteFood == favoriteFoods[i] è notFound = false;
        //MENTRE notFound rimane == true ripeti tutto 
        do
        {
            Console.WriteLine("Enter yours favorite food:"); // Prompt
            userFavoriteFood = Console.ReadLine(); // Get string from user
            computerFavoriteFood = new Random().Next(0, favoriteFoods.Length);

            for (int i = 0; i < favoriteFoods.Length; i++)
            {

                if (userFavoriteFood == favoriteFoods[i])
                {
                    notFound = false;
                }

            };

            if (notFound)
            {
                Console.WriteLine("no match found");
            }

        }
        while (notFound); // Loop indefinitely


        // Array length 
        Console.Write("\nTotal Number of Elements: ");
        Console.WriteLine(favoriteFoods.Length);

        Console.WriteLine("\nList of favourite foods:");
        //CICLA sulla lunghezza dell'arrey per stampare turtti gli elementi
        //SE userFavoriteFood == favoriteFoods[i] && i == computerFavoriteFood stampa XXX
        //ALTRIMENTI SE userFavoriteFood == favoriteFoods[i] stampa YYY
        //ALTRIMENTI SE i == computerFavoriteFood stampa ZZZ
        for (int i = 0; i < favoriteFoods.Length; i++)
        {
            Console.Write((i + 1) + "-" + favoriteFoods[i]);
            if (userFavoriteFood == favoriteFoods[i] && i == computerFavoriteFood)
            {

                Console.Write("==> abbiamo gli stessi gusti");
            } 
            else if (userFavoriteFood == favoriteFoods[i]) {

                Console.Write("==> questo è il cibo preferito dell' utente");
            }
            else if (i == computerFavoriteFood)
            {

                Console.Write("==> questo è il cibo preferito del computer");
            };
            Console.WriteLine();
        }

        // First Middle Last positions
        Console.WriteLine("\nfirst in the standings: " + favoriteFoods[0]);
        //Console.WriteLine("\nhalf in the standigs: " + favoriteFoods[favoriteFoods.Length / 2 - 1] + " " + favoriteFoods[favoriteFoods.Length / 2]);
        //Console.WriteLine("\nlast in the standings: " + favoriteFoods.Last());
        Console.WriteLine("last in the standings: " + favoriteFoods[favoriteFoods.Length - 1]);

        //IF favoriteFoods.Length / 2 == true stampa half in the standigs: " + favoriteFoods[favoriteFoods.Length / 2 ]
        //ALLORA half in the standigs: " + favoriteFoods[favoriteFoods.Length / 2 - 1] + " " + favoriteFoods[favoriteFoods.Length / 2])
        //if (favoriteFoods.Length % 2 == 0)
        //{
        //    Console.WriteLine("half in the standigs: " + favoriteFoods[favoriteFoods.Length / 2 - 1] + " and " + favoriteFoods[favoriteFoods.Length / 2]);
        //}
        //else
        //{
        //    Console.WriteLine("half in the standigs: " + favoriteFoods[favoriteFoods.Length / 2]);
        //}


        // più efficente
        bool iseven = favoriteFoods.Length % 2 == 0;
        int middle = favoriteFoods.Length / 2;
        if (iseven)
        {
            Console.WriteLine("half in the standigs: " + favoriteFoods[middle - 1] + " and " + favoriteFoods[middle]);
        }
        else
        {
            Console.WriteLine("half in the standigs: " + favoriteFoods[middle]);
        }
    }
};




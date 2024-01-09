using static System.Console;

Console.WriteLine("For Each Loop!");

// Iterating over string array
WriteLine("Iterating over string array...");

string[] colors = { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Voilet" };

foreach (var color in colors)
{
    Write(color + "\t");
}

WriteLine("");

// Iterating over generic string list"
WriteLine("Iterating over generic string list");

List<string> rainbow = new List<string>() { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Voilet" };

foreach (var color in rainbow)
{
    Write(color + "\t");
}


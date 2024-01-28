var message = """This is a very very long message, which is embedded using C#11 literal string format""";
Console.WriteLine(message);

Console.WriteLine();

var randomTextWithEscapeChars = """
    Once upon a time, in a distant realm where the sky painted itself in hues of violet and gold during the twilight hours, there existed a quaint village nestled between rolling hills and lush meadows. 
    
    The village, known as Eldoria, was a haven of serenity and charm, where cobblestone streets wound their way through clusters of quaint cottages adorned with vibrant flowers.
    
    \r\n\r\n
    
    Eldoria was renowned for its mystical aura, attributed to an ancient oak tree that stood at the heart of the village square. Legend had it that this majestic tree, named Yggdrasil, held the key to the ethereal balance that enveloped the entire region. Villagers believed that the whispers of the wind through Yggdrasil's leaves carried messages from the spirits of their ancestors, guiding them through the trials of life.
    """;

Console.WriteLine(randomTextWithEscapeChars);

Console.WriteLine();
var latitude = 12.3456789;
var longitude = 98.7654321;
var location = $$"""
    My coordnates: {{{latitude}}, {{{longitude}}}
    """;
Console.WriteLine(location);

Console.WriteLine();

// json array

var people = new[]
{
    new { Name = "John", Age = 20 },
    new { Name = "Jane", Age = 30 },
    new { Name = "Jack", Age = 40 },
    new { Name = "Jill", Age = 50 },
};

var json = $$"""
    [{{people[0]}}]
    """;
Console.WriteLine(json);



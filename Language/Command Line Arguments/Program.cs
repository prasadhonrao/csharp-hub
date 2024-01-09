Console.WriteLine("Command Line Arguments!");

#region Check input argument first

if (args.Length > 0) Console.WriteLine(args.Length);

//OR

if (args.Any()) Console.WriteLine(args.Length);

#endregion

#region Display input arguments

if (args.Any())
{
    foreach (var item in args)
    {
        Console.WriteLine(item);
    }
}

#endregion

#region Display command line information

var commandLine = Environment.CommandLine;
Console.WriteLine(commandLine);

#endregion

#region Console Title

Console.Title = "Command Line Arguments - Introduction";

for (int i = 0; i < 100; i++)
{
    Console.Title = string.Format("{0}% complete", i);
    Thread.Sleep(100);
}
Console.ReadLine();

#endregion

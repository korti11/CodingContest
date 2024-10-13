using CodingContest.Level;

var level = GetArgument("level", args);
var implementedLevel = GetLevel(int.Parse(level));
implementedLevel.Execute();

static string GetArgument(string argument, string[] args)
{
    var index = Array.IndexOf(args, $"--{argument}");
    return index >= 0 ? args[index + 1] : "-1";
}

static AbstractLevel GetLevel(int level)
{
    switch(level)
    {
        case 1:
            return null;
        case 2:
            return null;
        case 3:
            return null;
        case 4:
            return null;
        case 5:
            return null;
        case 6:
            return null;
        default:
            throw new ArgumentException("Selected level does not exists!");
    }
}
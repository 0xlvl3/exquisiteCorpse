
BuildAMonster("ghost", "bug", "monster");

static string BuildAMonster(string head, string body, string feet)
{
    switch (head)
    {
        case "ghost":
            GhostHead();
            break;
        case "bug":
            BugHead();
            break;
        case "monster":
            MonsterHead();
            break;
    }
    switch (body)
    {
        case "ghost":
            GhostBody();
            break;
        case "bug":
            BugBody();
            break;
        case "monster":
            MonsterBody();
            break;
    }
    switch (feet)
    {
        case "ghost":
            GhostFeet();
            break;
        case "bug":
            BugFeet();
            break;
        case "monster":
            MonsterFeet();
            break;
    }
    string build;
    build = $"{head}{body}{feet}";
    return build;
}

static void RandomMode()
{
    Random randomNumber = new Random();
    int head = randomNumber.Next(1, 4);
    int body = randomNumber.Next(1, 4);
    int feet = randomNumber.Next(1, 4);

}


//methods for the task
static void GhostHead()
{
    Console.WriteLine("     ..-..");
    Console.WriteLine("    ( o o )");
    Console.WriteLine("    |  O  |");
}

static void GhostBody()
{
    Console.WriteLine("    |     |");
    Console.WriteLine("    |     |");
    Console.WriteLine("    |     |");
}

static void GhostFeet()
{
    Console.WriteLine("    |     |");
    Console.WriteLine("    |     |");
    Console.WriteLine("    '~~~~~'");
}

static void BugHead()
{
    Console.WriteLine("     /   \\");
    Console.WriteLine("     \\. ./");
    Console.WriteLine("    (o + o)");
}

static void BugBody()
{
    Console.WriteLine("  --|  |  |--");
    Console.WriteLine("  --|  |  |--");
    Console.WriteLine("  --|  |  |--");
}

static void BugFeet()
{
    Console.WriteLine("     v   v");
    Console.WriteLine("     *****");
}

static void MonsterHead()
{
    Console.WriteLine("     _____");
    Console.WriteLine(" .-,;='';_),-.");
    Console.WriteLine("  \\_\\(),()/_/");
    Console.WriteLine("　  (,___,)");
}

static void MonsterBody()
{
    Console.WriteLine("   ,-/`~`\\-,___");
    Console.WriteLine("  / /).:.('--._)");
    Console.WriteLine(" {_[ (_,_)");
}

static void MonsterFeet()
{
    Console.WriteLine("    |  Y  |");
    Console.WriteLine("   /   |   \\");
    Console.WriteLine("   \"\"\"\" \"\"\"\"");
}

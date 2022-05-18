
//final method that will give the user a random monster
RandomMode();

//method will spit out a build of a monster
//we use multiple methods within this method
//first we use our translate to num method to change the strings to ints 
//then we use those ints within our switch method
static void BuildAMonster(string head, string body, string feet)
{
    //old switch statement used at the start of the task
    //switch (head)
    //{
    //    case "ghost":
    //        GhostHead();
    //        break;
    //    case "bug":
    //        BugHead();
    //        break;
    //    case "monster":
    //        MonsterHead();
    //        break;
    //}
    //switch (body)
    //{
    //    case "ghost":
    //        GhostBody();
    //        break;
    //    case "bug":
    //        BugBody();
    //        break;
    //    case "monster":
    //        MonsterBody();
    //        break;
    //}
    //switch (feet)
    //{
    //    case "ghost":
    //        GhostFeet();
    //        break;
    //    case "bug":
    //        BugFeet();
    //        break;
    //    case "monster":
    //        MonsterFeet();
    //        break;
    //}
    int intHead = TranslateToNumber(head);
    int intBody = TranslateToNumber(body);
    int intFeet = TranslateToNumber(feet);
    SwitchCase(intHead, intBody, intFeet);
    //string build;
    //build = $"{head}{body}{feet}";
    //return build;
}

//testing the random method
//RandomMode();

//method that will randomise a monster using the random class
static void RandomMode()
{
    Random randomNumber = new Random();
    int head = randomNumber.Next(1, 4);
    int body = randomNumber.Next(1, 4);
    int feet = randomNumber.Next(1, 4);
    SwitchCase(head, body, feet); 

}

//test from the method below
//SwitchCase(1, 2, 3);

//Method that will output a monster using the int values in the switch statement from 1-3
static int SwitchCase(int head, int body, int feet)
{
    switch (head)
    {
        case 1:
            GhostHead();
            break;
        case 2:
            BugHead();
            break;
        case 3:
            MonsterHead();
            break;
    }
    switch (body)
    {
        case 1:
            GhostBody();
            break;
        case 2:
            BugBody();
            break;
        case 3:
            MonsterBody();
            break;
    }
    switch (feet)
    {
        case 1:
            GhostFeet();
            break;
        case 2:
            BugFeet();
            break;
        case 3:
            MonsterFeet();
            break;
    }
    return head;
    return body;
    return feet;
}

//method will translate string creature to a int through the return statement
static int TranslateToNumber(string creature)
{
    switch (creature)
    {
        case "ghost":
            return 1;
        case "bug":
            return 2;
        case "monster":
            return 3;
            default:
            return 1;
    }
}

//methods for the task
//all methods are parts to monsters
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

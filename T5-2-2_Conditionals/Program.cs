Random random = new();
int randomNumber = random.Next(1, 11);

// if ... else statement - note that you don't need the else bit.
Console.Write($"{randomNumber} is ");

if (randomNumber % 2 == 0)
{
    Console.WriteLine("even.");
}
else
{
    Console.WriteLine("odd.");
}

Console.WriteLine();




// if ... else if ... else statement.
Console.Write($"{randomNumber} is ");

if (randomNumber >= 6)
{
    Console.WriteLine("greater than or equal to six.");
}
else if (randomNumber % 2 == 0)
{
    Console.WriteLine("less than six and even.");
}
else
{
    Console.WriteLine("less than six and odd.");
}

Console.WriteLine();




// if statement testing a boolean value directly = note how you don't need a comparison operator to ask if it's true.
bool boolean = randomNumber % 2 == 0;

Console.Write($"{randomNumber} is still ");

if (boolean)
{
    Console.WriteLine("even.");
}
else
{
    Console.WriteLine("odd.");
}

Console.WriteLine();





// switch statement.
Console.Write($"{randomNumber} is ");

switch (randomNumber)
{
    case 1:
    case 2:
    case 3:
        Console.WriteLine("between one and three.");
        break;

    case 4:
    case 5:
    case 6:
        Console.WriteLine("between four and six.");
        break;

    default:
        Console.WriteLine("big.");
        break;
}

Console.WriteLine();




// switch expression (C# 8 onwards).
var sentenceCompletion = randomNumber switch
{
    1 => "one.",
    2 => "two.",
    3 => "three.",
    _ => "who cares?"
};

Console.Write($"{randomNumber} is {sentenceCompletion}");

Console.WriteLine();




Console.ReadKey();

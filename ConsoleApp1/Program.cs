using System.Runtime.InteropServices;

Console.Clear();

// Variables
Random dice = new Random();
string player1Action = "";
string player2Action = "";

string mode = "";
bool win;
string[] actions = { "rock", "paper", "scissor" };

// Introduction
Console.WriteLine($"_-_-_-welcome to the game: rps spam (spam fake) -_-_-_");
Console.WriteLine($"how the game works: the game is like rock papper scissors but in the result of a draw the game turns in to a spaming game");
Console.WriteLine("the first one to take seven hp of the enemy or a player geats  KO (MEANING YOU WIN 3 ROUNDS IN A ROW)");
Console.WriteLine("");

// Player name
Console.Write("What is player one's name? ");
string player1 = Console.ReadLine();

// Game mode
Console.WriteLine($" TYPE e+ENTER KEY TO ENTER THE GAME PLAYING SOLO VS AI OR type vs+ENTER FOR MULTIPLAYER ");
while (mode != "e" && mode != "vs")
{
    mode = Console.ReadLine();
}
// spam static void
static void spam()
{
    int playeronenumber = 0;
    int playertwonumber = 0;
    Console.WriteLine("first to spam to 30 wins");
    Console.WriteLine("{player1} spam the F key {player2} spam the J key");
    Console.WriteLine("3");
    Console.WriteLine("2");
    Console.WriteLine("1");
    Console.WriteLine("go");
   
    while (playeronenumber < 30 && playertwonumber < 30)
    {
        ConsoleKeyInfo info = Console.ReadKey(true);

        if (info.KeyChar == 'f')
        {
            playeronenumber++;
        }
        if (info.KeyChar == 'j')
        {
            playertwonumber++;
        }
    }
    if (playeronenumber == 30)
    {
        Console.WriteLine("player 1 won player 2 lose");
    }
    if (playertwonumber == 30)
    {
        Console.WriteLine("player 2 won player 1 lose");
    }




    if (Console.readkey(true) != "Console")
}


// Vs AI
int playerhealth = 7;
int aihealth = 7;
while (mode == "e")
{
    Console.Clear();
    Console.WriteLine("You chose vs AI");

    // health
    Console.WriteLine($"You {player1} have {playerhealth} Health");
    Console.WriteLine($"The ai has {aihealth} Health");

    // Player action selection
    Console.Write("Do you pick rock, paper or scissor? ");
    while (player1Action != "rock" && player1Action != "paper" && player1Action != "scissor")
    {
        player1Action = Console.ReadLine().ToLower();
    }

    // AI action selection
    string AiAction = actions[dice.Next(3)];

    Console.WriteLine($"You chose {player1Action}, The Ai chose {AiAction}");
    Console.ReadLine();

    if (player1Action == "rock" && AiAction == "scissor")
    {
        aihealth--;
    }
    if (player1Action == "paper" && AiAction == "rock")
    {
        aihealth--;
    }
    if (player1Action == "scissor" && AiAction == "paper")
    {
        aihealth--;
    }
    if (player1Action == "scissor" && AiAction == "rock")
    {
        playerhealth--;
    }
    if (player1Action == "rock" && AiAction == "paper")
    {
        playerhealth--;
    }
    if (player1Action == "paper" && AiAction == "scissor")
    {
        playerhealth--;
    }
    player1Action = "";
    if (player1Action == AiAction)
    {
        //add spam game
    }
    if (aihealth <= 0)
    {
        Console.WriteLine("You won");
        Console.ReadLine();
        mode = "";
    }
    if (playerhealth <= 0)
    {
        Console.WriteLine("You lost");
        Console.ReadLine();
        mode = "";
    }
}

// Vs PlayerS
int player1health = 7;
int player2health = 7;

while (mode == "vs")
{
    Console.Clear();
    Console.WriteLine("You chose vs player what is player2s name");
    string player2 = Console.ReadLine(); s

    Console.WriteLine($"p1 {player1}-{player1health} Health");
    Console.WriteLine($"p2 {player2}-{player2health} Health");

    Console.Write("Do you p1 pick rock, paper or scissor? ");
    while (player1Action != "rock" && player1Action != "paper" && player1Action != "scissor")
    {
        player1Action = Console.ReadLine().ToLower();
    }
    Console.Write("Do you p2 pick rock, paper or scissor? ");
    while (player2Action != "rock" && player2Action != "paper" && player2Action != "scissor")
    {
        player2Action = Console.ReadLine().ToLower();
    }
    Console.WriteLine($"You chose {player1Action}, The p2 chose {player2Action}");
    Console.ReadLine();

    if (player1Action == "rock" && player2Action == "scissor")
    {
        player2health--;
    }
    if (player1Action == "paper" && player2Action == "rock")
    {
        player2health--;
    }
    if (player1Action == "scissor" && player2Action == "paper")
    {
        player2health--;
    }


    if (player1Action == "scissor" && player2Action == "rock")
    {
        player1health--;
    }
    if (player1Action == "rock" && player2Action == "paper")
    {
        player1health--;
    }
    if (player1Action == "paper" && player2Action == "scissor")
    {
        player1health--;
    }

    // in case of draw spam
    if (player1Action == player2Action)
    {
        spam
    }


    player1Action = "";
    player2Action = "";

    if (player2health <= 0)
    {
        Console.WriteLine("p1 won");
        Console.ReadLine();
        mode = "";
    }
    if (player1health <= 0)
    {
        Console.WriteLine("p2 won");
        Console.ReadLine();
        mode = "";
    }
}


Console.Clear();







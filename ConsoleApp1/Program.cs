﻿Console.Clear();

// Variables
Random dice = new Random();
string player1Action = "";
string mode = "";

// Introduction
Console.WriteLine($"_-_-_-welcome to the game: rps spam -_-_-_");
Console.WriteLine($"how the game works: the game is like rock papper scissors but in the result of a draw the game turns in to a spaming game");
Console.WriteLine("the first one to take seven hp of the enemy or a player geats  KO (MEANING YOU WIN 3 ROUNDS IN A ROW)");

// Player name
Console.Write("What is player one's name?");
string player1 = Console.ReadLine();

// Game mode
Console.WriteLine($" TYPE e+ENTER KEY TO ENTER THE GAME PLAYING SOLO VS AI OR type vs+ENTER FOR MULTIPLAYER ");
while (mode != "e" && mode != "vs")
{
    mode = Console.ReadLine();
}

// Vs AI
while (mode == "e")
{
    Console.Clear();
    Console.WriteLine("You chose vs AI");

    // Player action selection
    Console.Write("Do you pick rock, paper or scissor? ");
    while (player1Action != "rock" || player1Action != "paper" || player1Action != "scissor"){
        player1Action = Console.ReadLine().ToLower();
    }
    
    // AI action selection
    int AiAction = dice.Next(2);
    
    
}

// Vs Player
while (mode == "vs")
{
    Console.Clear();
    Console.WriteLine("You chose vs player what is players name");
}






Console.Clear();


Console.ReadKey();





// See https://aka.ms/new-console-template for more information


using Queues_Sawyer_Moira;
{
    // A Game object thats max is 50 players and current players to 49.
    Game myGame = new Game(50, 49);

    //  A Queue of Player objects.
    Queue<Player> waitingToJoinQ = new Queue<Player>();
    
    // 4 player objects with 100% health and unique gamertags.
    Player p1 = new Player(100, "PapaAintNoHobbit777");
    Player p2 = new Player(100, "nicofreak0");
    Player p3 = new Player(100, "AceyAir-Conditioner");
    Player p4 = new Player(100, "xXPookieXx");

    // Calls JoinGame on all 4 player objects; passing through the game and queue as arguments.
    p1.JoinGame(myGame, waitingToJoinQ);
    p2.JoinGame(myGame, waitingToJoinQ);
    p3.JoinGame(myGame, waitingToJoinQ);
    p4.JoinGame(myGame, waitingToJoinQ);

    // Prints, "Players in da Q" to the console.
    Console.WriteLine("Players in da Q:");
    foreach(Player player in waitingToJoinQ)
    {
        // Loops through the queue and print all the players on a new line.
        Console.WriteLine(player);
    }

    // Calls KickPlayer on the game.
    myGame.KickPlayer();

    // Calls CheckQueue on the game.
    myGame.CheckQueue(waitingToJoinQ);

    //  Prints, "\nPlayers in da" to console.
    Console.WriteLine("\nPlayers in da Q:");
    foreach (Player player in waitingToJoinQ)
    {
    // Loops through the queue and print all the players on a new line.
        Console.WriteLine(player);
    }
}

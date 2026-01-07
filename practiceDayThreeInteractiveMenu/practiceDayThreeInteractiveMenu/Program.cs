bool keepPlaying = true;

 while (keepPlaying) {
    Console.Clear();
    Console.WriteLine("Hey there! Welcome to the start of your adventure! Choose where you'll start :)");
    Console.WriteLine();
    Console.WriteLine("1: The beginning");
    Console.WriteLine("2: The middle somewhere...");
    Console.WriteLine("3: Mystery option");
    Console.WriteLine();
    Console.Write("Enter your choice, wanderer: 1, 2 or 3: ");

    string choice = Console.ReadLine();

    if (choice == "1")
    {
        Console.WriteLine();
        Console.WriteLine("Hey, you. You’re finally awake.");
        Console.WriteLine("You were trying to cross the border, right?");
        Console.WriteLine("Walked right into that Imperial ambush, same as us, and that thief over there.");
        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
}
    else if (choice == "2")
    {
        Console.WriteLine();
        Console.WriteLine("You open the door marked 'Exit', step through, and immediately find yourself holding the door open for the version of you that already left.");
        Console.WriteLine();
        Console.WriteLine("You both step through the door, and it closes behind you.");
        Console.WriteLine();
        Console.WriteLine("Confused? Me too...");
        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
    else if (choice == "3")
    {
        Console.WriteLine();
        Console.WriteLine("Oh no... you died...");
        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    else
    {
        Console.WriteLine();
        Console.WriteLine("That's not a valid choice... come on man...");
        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    Console.WriteLine();
    Console.Write("Do you want to play again? (y/n): ");
    string playAgain = Console.ReadLine();
    if (playAgain.Trim().ToLower() != "y")
        {
        keepPlaying = false;
    }
}

Console.Clear();
Console.WriteLine("Thanks for playing. Until next time, wanderer.");

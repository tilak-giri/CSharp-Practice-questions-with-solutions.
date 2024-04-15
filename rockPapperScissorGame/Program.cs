string user;
string computer;
bool playAgain = true;
Random newRandom = new Random();
string again;

while (playAgain)
{
    user = "";
    computer = "";
    Console.WriteLine("Enter Rock, Paper, or Scissor");
    user = Console.ReadLine();
    user = user.ToLower();


    while (user != "")
    {
        
        int machine = newRandom.Next(1, 4);
        switch (machine)
        {
            case 1:
                computer = "rock";
                break;
            case 2:
                computer = "paper";
                break;
            case 3:
                computer = "scissor";
                break;
        }
        Console.WriteLine("Player: " + user);
        Console.WriteLine("Computer: " + computer);
        break;
    }


    switch (user)
    {
        case "rock":
            if (computer == "rock")
            {
                Console.WriteLine("Draw!");
            }
            else if (computer == "paper")
            {
                Console.WriteLine("You loose!");
            }
            else
            {
                Console.WriteLine("You Win!!!");
            }
            break;
        case "paper":
            if (computer == "rock")
            {
                Console.WriteLine("You win!!!");
            }
            else if (computer == "paper")
            {
                Console.WriteLine("Draw!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }
            break;
        case "scissor":
            if (computer == "rock")
            {
                Console.WriteLine("You lose!");
            }
            else if (computer == "paper")
            {
                Console.WriteLine("You win!!!");
            }
            else
            {
                Console.WriteLine("Draw!");
            }
            break;
    }

    Console.WriteLine("Do you want to play again? Enter Y/N:");
    again = Console.ReadLine();
    again = again.ToLower();
    if (again == "y")
    {
        playAgain = true;
    }
    else
    {
        playAgain = false;
    }
    if(again == "n")
    {
        Console.WriteLine("Thank you for playing!!!");
    }
}


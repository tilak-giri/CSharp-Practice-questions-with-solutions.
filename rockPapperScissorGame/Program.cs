// using System;

// namespace MyFirstProgram
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Random random = new Random();
//             bool playAgain = true;
//             String player;
//             String computer;
//             String answer;

//             while (playAgain)
//             {
//                 player = "";
//                 computer = "";
//                 answer = "";

//                 while (player != "ROCK" && player != "PAPER" && player != "SCISSORS") {
//                     Console.Write("Enter ROCK, PAPER, or SCISSORS: ");
//                     player = Console.ReadLine();
//                     player = player.ToUpper();
//                 }


//                 switch (random.Next(1, 4))
//                 {
//                     case 1:
//                         computer = "ROCK";
//                         break;
//                     case 2:
//                         computer = "PAPER";
//                         break;
//                     case 3:
//                         computer = "SCISSORS";
//                         break;
//                 }

//                 Console.WriteLine("Player: " + player);
//                 Console.WriteLine("Computer: " + computer);

//                 switch (player)
//                 {
//                     case "ROCK":
//                         if (computer == "ROCK")
//                         {
//                             Console.WriteLine("It's a draw!");
//                         }
//                         else if (computer == "PAPER")
//                         {
//                             Console.WriteLine("You lose!");
//                         }
//                         else
//                         {
//                             Console.WriteLine("You win!");
//                         }
//                         break;
//                     case "PAPER":
//                         if (computer == "ROCK")
//                         {
//                             Console.WriteLine("You win!");
//                         }
//                         else if (computer == "PAPER")
//                         {
//                             Console.WriteLine("It's a draw!");
//                         }
//                         else
//                         {
//                             Console.WriteLine("You lose!");
//                         }
//                         break;
//                     case "SCISSORS":
//                         if (computer == "ROCK")
//                         {
//                             Console.WriteLine("You lose!");
//                         }
//                         else if (computer == "PAPER")
//                         {
//                             Console.WriteLine("You win!");
//                         }
//                         else
//                         {
//                             Console.WriteLine("It's a draw!");
//                         }
//                         break;
//                 }

//                 Console.Write("Would you like to play again (Y/N): ");
//                 answer = Console.ReadLine();
//                 answer = answer.ToUpper();

//                 if (answer == "Y")
//                 {
//                     playAgain = true;
//                 }
//                 else
//                 {
//                     playAgain = false;
//                 }

//             }

//             Console.WriteLine("Thanks for playing!");

//             Console.ReadKey();
//         }
//     }
// }

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


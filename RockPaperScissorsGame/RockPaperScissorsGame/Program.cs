namespace RockPaperScissorsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;
            string answer;

            while (playAgain) {
                player = "";
                computer = "";
                answer = "";

                while (player!="ROCK" && player !="PAPER" && player !="SCISSORS") {
                    Console.Write("Enter Rock, Paper or Scissors : ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

                switch (random.Next(1, 4)) { 
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break ;
                    case 3:
                        computer = "SCISSORS";
                        break ;
                }
                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                switch (player) {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("It's a Draw!");
                        }
                        else if(computer == "PAPER"){
                            Console.WriteLine("You Lose!");
                        }
                        else{
                            Console.WriteLine("You Win");
                        }
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You Win!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a Draw!");
                        }
                        else
                        {
                            Console.WriteLine("You Lose!");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You Lose!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You Win!");
                        }
                        else
                        {
                            Console.WriteLine("It's a Draw!");
                        }
                        break;
                }
                Console.Write("Would You like to play again (Y/N): ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y" || answer == "YES")
                {
                    playAgain = true;
                }
                else { 
                    playAgain = false;
                }
            }
            Console.WriteLine("Thanks For Playing");
            Console.ReadKey();
        }
    }
}

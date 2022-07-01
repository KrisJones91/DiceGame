
int playerRandomNum;
int opponentRandomNum;

int playerPoints = 0;
int opponentPoints = 0;

Random random = new Random();


for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Press any Key to roll the dice");
    Console.ReadKey();

    playerRandomNum = random.Next(1, 7);
    Console.WriteLine("You rolled a {0}", playerRandomNum);

    Console.WriteLine("...");
    System.Threading.Thread.Sleep(1000);

    opponentRandomNum = random.Next(1, 7);
    Console.WriteLine("Opponent rolled a {0}", opponentRandomNum);

    if (playerRandomNum > opponentRandomNum)
    {
        playerPoints++;
        Console.WriteLine("You win!");
    }
    else if (playerRandomNum < opponentRandomNum)
    {
        opponentPoints++;
        Console.WriteLine("Opponent wins!");

    }
    else
    {
        Console.WriteLine("It's a DRAW!!");
    }

    Console.WriteLine("[SCORE] -- Player: {0} / Opponent {1}", playerPoints, opponentPoints);
    Console.WriteLine("\n");


};
if (playerPoints > opponentPoints)
{
    Console.WriteLine("You win!");
}

if (playerPoints < opponentPoints)
{
    Console.WriteLine("Opponent wins!");
}
if (playerPoints == opponentPoints)
{
    Console.WriteLine("Its a Draw");
}

Console.ReadKey();




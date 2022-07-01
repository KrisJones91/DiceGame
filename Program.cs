
int playerRandomNum;
Random random = new Random();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Press any Key to roll the dice");
    Console.ReadKey();

    playerRandomNum = random.Next(1, 7);

    Console.WriteLine("You rolled a {0}", playerRandomNum);

}
Console.ReadKey();





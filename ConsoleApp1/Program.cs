namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool game = true;
            Random random = new Random();
            while (game)
            {
                int[] rolls = Enumerable
                    .Repeat(0, 4)
                    .Select(i => random.Next(1, 7))
                    .ToArray();

                Console.WriteLine($"Your first roll is  {rolls[0]}, your second roll is {rolls[1]}, your total sum is {rolls[0] + rolls[1]}");
                if ((rolls[0] + rolls[1]) > rolls[2] + rolls[3])
                {
                    Console.WriteLine($"The computer scored higher you've lost, the computer scored {rolls[2] + rolls[3]} with rolls of {rolls[2]} and {rolls[3]}");
                    game = validateMethod();
                }
                else if((rolls[0] + rolls[1]) < rolls[2] + rolls[3])
                {
                    Console.WriteLine($"The computer has lost, it scored {rolls[2] + rolls[3]} with rolls of {rolls[2]} and {rolls[3]}");
                    game = validateMethod();
                }
                else
                {
                    Console.WriteLine("The game is a draw");
                    game = validateMethod();
                }
            }

            static bool validateMethod()
            {
                Console.Write("Do you want to continue playing? y/n");
                string answer = Console.ReadLine();
                if (answer.ToLower().Equals("y")){ return true;}
                else if (answer.ToLower().Equals("n")) { return false; }
                else
                {
                    Console.WriteLine("Not one of the options");
                    bool playOn = validateMethod();
                    return playOn;
                }
            }
        }
    }
}
    


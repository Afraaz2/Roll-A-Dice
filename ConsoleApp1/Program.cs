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
                int a = random.Next(1, 7);
                int b = random.Next(1, 7);
                int userSum = a + b;
                Console.WriteLine($"Your first roll is  {a}, your second roll is {b}, your total sum is {userSum}");
                int x = random.Next(1, 7);
                int d = random.Next(1, 7);
                if ((x + d) > userSum)
                {
                    Console.WriteLine($"The computer scored higher you've lost, the computer scored {x + d}");
                    game = validateMethod();
                }
                else
                {
                    Console.WriteLine($"The computer has lost, it scored {x + d}");
                }
            }




            static bool validateMethod()
            {
                Console.WriteLine("Do you want to continue playing? y/n");
                string answer = Console.ReadLine();
                if (answer.Equals("y"))
                {
                    return true;
                }
                else if (answer.Equals("n")) { return false; }
                else
                {
                    Console.WriteLine("Not one of the options");
                    bool answer2 = validateMethod();
                    return answer2;
                }
            }
        }
    }
}
    


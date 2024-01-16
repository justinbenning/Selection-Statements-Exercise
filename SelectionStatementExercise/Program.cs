using System.Reflection.Metadata;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main()
        {
            
            var r = new Random();
            decimal favNumber = r.Next(1, 1001);
            int difference500 = 500;
            int absoluteValue500 = Math.Abs(difference500);
            int difference250 = 250;
            int absoluteValue250 = Math.Abs(difference250);
            decimal userGuess = 0;

            do
            {
                Console.WriteLine("Guess a number from 1 to 1000:");
                userGuess = int.Parse(Console.ReadLine()!);

                if ((favNumber - userGuess) >= 500 || (favNumber - userGuess) <= -(500))
                {
                    Console.WriteLine("You are more than 500 away, you might want to give up.");
                }
                else if ((favNumber - userGuess) >= 250 || (favNumber - userGuess) <= -(250) && userGuess > favNumber)
                {
                    Console.WriteLine("Not great, try again. This time lower.");
                }
                else if ((favNumber - userGuess) >= 250 || (favNumber - userGuess) <= -(250) && userGuess < favNumber)
                {
                    Console.WriteLine("Not great, try again. This time higher.");
                }
                else if (favNumber > userGuess)
                {
                    Console.WriteLine("Higher");
                }
                else if (favNumber < userGuess)
                {
                    Console.WriteLine("Lower");
                }
                else if (favNumber == userGuess == 69)
                {
                    Console.WriteLine("Nice.");
                }
                else
                {
                    Console.WriteLine("Nailed it!");
                }
            } while (userGuess != favNumber);

        }
    }
}

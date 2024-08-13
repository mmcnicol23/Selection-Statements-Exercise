namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)

        {
            int favNumber = 4;
            bool i = true;
            while (i == true)
            {
                Console.WriteLine("Guess my favorite number between 1 and 10!");
                int userInput = int.Parse(Console.ReadLine());

                if (userInput < 7)
                {
                    Console.WriteLine("Too low!");
                    i = true;
                }

                else if (userInput > 7)
                {
                    Console.WriteLine("Too high!");
                    i = true;
                }

                else
                {
                    Console.WriteLine("You guessed it! Great job!");
                    i = false;
                }
            }
        }
    }
    
}
    
